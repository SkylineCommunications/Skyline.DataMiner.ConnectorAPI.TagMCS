using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Skyline.DataMiner.ConnectorAPI.TagMCS.InterApp.Executors;
using Skyline.DataMiner.ConnectorAPI.TagMCS.InterApp.Messages;
using Skyline.DataMiner.Core.DataMinerSystem.Common;
using Skyline.DataMiner.Core.DataMinerSystem.Common.Selectors;
using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
using Skyline.DataMiner.Core.InterAppCalls.Common.MessageExecution;
using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
using Skyline.DataMiner.Net;

namespace Skyline.DataMiner.ConnectorAPI.TagMCS
{
    /// <summary>
    /// Enum for specifying what type of information you are passing to the message for the Channel/Layout.
    /// </summary>
    public enum MessageIdentifier
    {
        /// <summary>
        /// ID will mean that you are passing the Id of the Channel/Layout
        /// </summary>
        ID = 0,
        /// <summary>
        /// Name will mean that you are passing the Name of the Channel/Layout
        /// </summary>
        Name = 1,
    }

    /// <summary>
	///     Represents a TAG MCS Element that allows to interface with it's API through Inter App messages.
	/// </summary>
    public class TagMCS
    {
        private const int InterAppReceiverPid = 9000000;
        private const int InterAppSenderPid = 9000001;

        private readonly IConnection _connection;
        private readonly IDmsElement _element;
        private TimeSpan timeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="TagMCS" /> class.
        /// </summary>
        /// <param name="connection">Connection used to communicate with the Tag MCS Element</param>
        /// <param name="agentId">Agent ID of the Tag MCS Element</param>
        /// <param name="elementId">Element ID of the Tag MCS Element</param>
        /// <exception cref="ElementNotFoundException">Thrown when the element is not found, or the element that is found is not a Tag MCS</exception>
        /// <exception cref="ElementStoppedException">Thrown when the element is not active</exception>
        public TagMCS(IConnection connection, int agentId, int elementId)
        {
            _connection = connection;
            var dms = _connection.GetDms();
            var id = new DmsElementId(agentId, elementId);

            _element = dms.GetElement(id);
            if(_element.Protocol.Name != "TAG Video Systems Media Control System (MCS)")
            {
                throw new ElementNotFoundException($"Element {_element.Name} is not a TAG MCS Element");
            }

            if(_element.State != ElementState.Active)
            {
                throw new ElementStoppedException($"Element {_element.Name} is not active");
            }
        }

        /// <summary>
		///     List of Known InterApp Messages (Types) to be used during InterApp communication.<br />
		///     Required under the hood to correctly map the executors and types of messages.
		/// </summary>
        public static List<Type> KnownTypes { get; } = new List<Type>
        {
            typeof(SetChannelInLayoutRequest),
            typeof(InterAppResponse),
        };

        /// <summary>
		///     List of which executor needs to handle which type of message.<br />
		///     Required under the hood to correctly handle the communication.
		/// </summary>
        public static Dictionary<Type, Type> ExecutorMapping { get; } = new Dictionary<Type, Type>
        {
            { typeof(InterAppResponse), typeof(InterAppExecutor) }
        };

        /// <summary>
		///     Maximum amount of time in which every request to the chassis should be handled.<br />
		///     Default: 10 seconds.<br />
		///     Maximum: 2 minutes.<br />
		/// </summary>
        public TimeSpan Timeout
        {
            get => timeout;
            set => timeout = value <= TimeSpan.FromSeconds(120) ? value : TimeSpan.FromSeconds(120);
        }

        /// <summary>
        /// Send the message to the Tag MCS Element
        /// </summary>
        /// <param name="message">The message to send to the Tag MCS</param>
        /// <param name="logger">Optional Logger functionality</param>
        /// <returns></returns>
        public InterAppResponse SendMessage(Message message, Action<string> logger = null)
        {
            try
            {
                IInterAppCall commands = InterAppCallFactory.CreateNew();
                commands.Messages.Add(message);
                commands.Source = new Source("AppearX_Element");
                commands.ReturnAddress = new ReturnAddress(_element.AgentId, _element.Id, InterAppSenderPid);

                Message returnedMessage = commands.Send(_connection, _element.AgentId, _element.Id, InterAppReceiverPid, timeout, KnownTypes).FirstOrDefault();
                if (returnedMessage == null)
                {
                    logger?.Invoke($"{_element.Name}|{nameof(SendMessage)}|Received response was null...");
                    return new InterAppResponse { Success = false, ResponseMessage = "No InterApp response received." };
                }

                IMessageExecutor executor = returnedMessage.CreateExecutor(ExecutorMapping);
                bool status = executor.Validate();

                logger?.Invoke(
                    status
                        ? $"{_element.Name}|Response status: OK, message: {executor}"
                : $"{_element.Name}|Response status: FAIL, message: {executor}");

                return new InterAppResponse { Success = status, ResponseMessage = executor.ToString() };
            }
            catch (TimeoutException)
            {
                logger?.Invoke($"{_element.Name}|{nameof(SendMessage)}|Message timed out...");
                return new InterAppResponse { Success = false, ResponseMessage = "Message Timed out..." };
            }
            catch (Exception e)
            {
                logger?.Invoke($"{_element.Name}|{nameof(SendMessage)}|Exception: {e}");
                return new InterAppResponse { Success = false, ResponseMessage = e.ToString() };
            }
        }
    }
}