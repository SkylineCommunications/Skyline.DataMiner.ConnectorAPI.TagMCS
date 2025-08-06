namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Request to update a Output Configuration on TAG
    /// </summary>
    public class SetOutputConfigRequest : Message
    {
        /// <summary>
        /// The Output Configuration to be set on TAG
        /// </summary>
        public OutputData Output { get; set; }
    }
}
