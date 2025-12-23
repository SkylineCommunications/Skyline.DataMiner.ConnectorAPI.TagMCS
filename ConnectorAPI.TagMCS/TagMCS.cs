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
    /// Represents the TAG MCS API endpoint groups used for TAG communication.
    /// Each enum member corresponds to a numeric API endpoint identifier used in InterApp requests.
    /// </summary>
    public enum ApiEndpoints
    {
        /// <summary>
        /// Authentication: Login endpoint (100).
        /// </summary>
        Login_100 = 100,

        /// <summary>
        /// Authentication: Login refresh endpoint (101).
        /// </summary>
        LoginRefresh_101 = 101,

        /// <summary>
        /// Authentication: Revoke token endpoint (102).
        /// </summary>
        RevokeToken_102 = 102,

        /// <summary>
        /// Users management endpoint (1000).
        /// </summary>
        Users_1000 = 1000,

        /// <summary>
        /// User sessions endpoint (1100).
        /// </summary>
        UsersSessions_1100 = 1100,

        /// <summary>
        /// Devices management endpoint (1200).
        /// </summary>
        Devices_1200 = 1200,

        /// <summary>
        /// Devices hardware information endpoint (1300).
        /// </summary>
        DevicesHardware_1300 = 1300,

        /// <summary>
        /// Devices statistics endpoint (1400).
        /// </summary>
        DevicesStatistics_1400 = 1400,

        /// <summary>
        /// Current tasks endpoint (1700).
        /// </summary>
        CurrentTasks_1700 = 1700,

        /// <summary>
        /// Network configurations endpoint (1800).
        /// </summary>
        NetworkConfigurations_1800 = 1800,

        /// <summary>
        /// System files endpoint (1900).
        /// </summary>
        SystemFiles_1900 = 1900,

        /// <summary>
        /// System redundancy endpoint (1905).
        /// </summary>
        SystemRedundancy_1905 = 1905,

        /// <summary>
        /// DNS configuration endpoint (2000).
        /// </summary>
        DNSConfiguration_2000 = 2000,

        /// <summary>
        /// Channels configuration endpoint (2100).
        /// </summary>
        ChannelsConfiguration_2100 = 2100,

        /// <summary>
        /// Channel scans configuration endpoint (2800).
        /// </summary>
        ChannelScansConfiguration_2800 = 2800,

        /// <summary>
        /// Channel scans status endpoint (3000).
        /// </summary>
        ChannelScansStatus_3000 = 3000,

        /// <summary>
        /// Outputs configuration endpoint (3100).
        /// </summary>
        OutputsConfiguration_3100 = 3100,

        /// <summary>
        /// Layout templates endpoint (3500).
        /// </summary>
        LayoutsTemplates_3500 = 3500,

        /// <summary>
        /// Layouts configuration endpoint (3600).
        /// </summary>
        LayoutsConfiguration_3600 = 3600,

        /// <summary>
        /// NTP configuration endpoint (3700).
        /// </summary>
        NTPConfiguration_3700 = 3700,

        /// <summary>
        /// PTP configuration endpoint (3800).
        /// </summary>
        PTPConfiguration_3800 = 3800,

        /// <summary>
        /// Timezones configuration endpoint (3900).
        /// </summary>
        TimezonesConfiguration_3900 = 3900,

        /// <summary>
        /// Scheduler configuration endpoint (4100).
        /// </summary>
        SchedulerConfiguration_4100 = 4100,

        /// <summary>
        /// KMS configuration endpoint (4300).
        /// </summary>
        KMSConfiguration_4300 = 4300,

        /// <summary>
        /// Thresholds configuration endpoint (4400).
        /// </summary>
        ThresholdsConfiguration_4400 = 4400,

        /// <summary>
        /// Notifications configuration endpoint (4500).
        /// </summary>
        NotificationsConfiguration_4500 = 4500,

        /// <summary>
        /// Channel path configuration endpoint (4600).
        /// </summary>
        ChannelPathConfiguration_4600 = 4600,

        /// <summary>
        /// Channels events endpoint (5100).
        /// </summary>
        ChannelsEvents_5100 = 5100,

        /// <summary>
        /// Channels status endpoint (5300).
        /// </summary>
        ChannelsStatus_5300 = 5300,

        /// <summary>
        /// Channels thumbnails endpoint (5399).
        /// </summary>
        ChannelsThumbnails_5399 = 5399,

        /// <summary>
        /// Outputs status endpoint (5900).
        /// </summary>
        OutputsStatus_5900 = 5900,

        /// <summary>
        /// Thresholds configuration metadata endpoint (6100).
        /// </summary>
        ThresholdsConfigMeta_6100 = 6100,

        /// <summary>
        /// Layouts configuration metadata endpoint (6500).
        /// </summary>
        LayoutsConfigMeta_6500 = 6500,

        /// <summary>
        /// Groups retrieval endpoint (6601).
        /// </summary>
        GetGroups_6601 = 6601,

        /// <summary>
        /// Tiles configuration endpoint (6700).
        /// </summary>
        TilesConfig_6700 = 6700,

        /// <summary>
        /// Penalty box configuration endpoint (7200).
        /// </summary>
        PenaltyBoxConfig_7200 = 7200,
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
            if (_element.Protocol.Name != "TAG Video Systems Media Control System (MCS)")
            {
                throw new ElementNotFoundException($"Element {_element.Name} is not a TAG MCS Element");
            }

            if (_element.State != ElementState.Active)
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
            typeof(GenericPatchRequest),
            typeof(GenericPatchResponse),
            typeof(SetChannelConfigRequest),
            typeof(SetLayoutConfigRequest),
            typeof(GetLayoutConfigRequest),
            typeof(GetLayoutConfigResponse),
            typeof(GetOutputConfigRequest),
            typeof(GetOutputConfigResponse),
            typeof(SetOutputConfigRequest),
            typeof(UpdateChannelRequest),
            typeof(CreateSchedulerConfigRequest),
            typeof(CreateSchedulerConfigResponse),
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}