namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Request to update a Channel Configuration on TAG
    /// </summary>
    public class SetLayoutConfigRequest : Message
    {
        /// <summary>
        /// The Channel Configuration to be set on TAG
        /// </summary>
        public Layout Layout { get; set; }
    }
}
