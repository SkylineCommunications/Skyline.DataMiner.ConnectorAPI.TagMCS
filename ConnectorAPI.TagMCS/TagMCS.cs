namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages;
    using Skyline.DataMiner.Core.DataMinerSystem.Common;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallBulk;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Core.InterAppCalls.Common.Shared;
    using Skyline.DataMiner.Net;

    /// <summary>
    /// Enum for specifying what type of information the message will contain.
    /// </summary>
    public enum MessageIdentifier
    {
        /// <summary>
        /// ID will mean that the message only uses IDs.
        /// </summary>
        ID = 0,
        /// <summary>
        /// Name will mean that the message only uses Names.
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

            if (!HasParameter(_element, InterAppReceiverPid))
            {
                throw new InvalidVersionException($"Element {_element.Name} is not using a version where InterApp is implemented");
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
            typeof(GetChannelConfigRequest),
            typeof(GetChannelConfigResponse),
            typeof(SetChannelConfigRequest),
            typeof(SetLayoutConfigRequest),
            typeof(GetLayoutConfigRequest),
            typeof(GetLayoutConfigResponse),
            typeof(GetOutputConfigRequest),
            typeof(GetOutputConfigResponse),
            typeof(SetOutputConfigRequest),
        };

        /// <summary>
		///     List of which executor needs to handle which type of message.<br />
		///     Required under the hood to correctly handle the communication.
		/// </summary>
        public static Dictionary<Type, Type> ExecutorMapping { get; } = new Dictionary<Type, Type>
        {
        };

        /// <summary>
        /// Send the message to the Tag MCS Element
        /// </summary>
        /// <param name="message">The message to send to the Tag MCS</param>
        /// <param name="timeout">The time the interapp call will wait for a response.</param>
        /// <param name="logger">A method for debugging the interapp calls.</param>
        /// <returns></returns>
        public Message SendMessage(Message message, TimeSpan timeout, Action<string> logger = null)
        {
            try
            {
                IInterAppCall commands = InterAppCallFactory.CreateNew();
                commands.Messages.Add(message);
                commands.Source = new Source("TagMCS_Element");
                commands.ReturnAddress = new ReturnAddress(_element.AgentId, _element.Id, InterAppSenderPid);

                Message returnedMessage = commands.Send(_connection, _element.AgentId, _element.Id, InterAppReceiverPid, timeout, KnownTypes).FirstOrDefault();
                if (returnedMessage == null)
                {
                    logger?.Invoke("No InterApp Response received.");
                    return new InterAppResponse { Success = false, ResponseMessage = "No InterApp response received." };
                }

                return returnedMessage;
            }
            catch (TimeoutException)
            {
                logger?.Invoke("Message Timed out...");
                return new InterAppResponse { Success = false, ResponseMessage = "Message Timed out..." };
            }
            catch (Exception e)
            {
                logger?.Invoke(e.ToString());
                return new InterAppResponse { Success = false, ResponseMessage = e.ToString() };
            }
        }

        private static bool HasParameter(IDmsElement element, int pid)
        {
            try
            {
                element.GetStandaloneParameter<string>(pid).GetValue();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}