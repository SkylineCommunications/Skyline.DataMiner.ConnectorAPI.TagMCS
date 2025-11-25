namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Represents the response message for creating a scheduler configuration
    /// </summary>
    public class CreateSchedulerConfigResponse : Message
    {
        /// <summary>
        /// Contains the boolean value on whether the request succeeded or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Contains any additional information for the response, such as why the request may have failed
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Contains the scheduler configuration that was created
        /// </summary>
        public SchedulerConfig SchedulerConfig { get; set; }
    }
}
