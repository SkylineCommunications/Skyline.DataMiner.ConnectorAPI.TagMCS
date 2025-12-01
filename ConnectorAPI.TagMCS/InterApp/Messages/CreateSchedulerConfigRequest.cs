namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Inter-app call request message to create a new scheduler configuration.
    /// </summary>
    /// <remarks>
    /// Populate <see cref="SchedulerConfig"/> with the desired scheduler configuration details before sending this message.
    /// </remarks>
    public class CreateSchedulerConfigRequest : Message
    {
        /// <summary>
        /// Gets or sets the scheduler configuration to be created.
        /// </summary>
        public SchedulerConfigRequest SchedulerConfig { get; set; }
    }
}
