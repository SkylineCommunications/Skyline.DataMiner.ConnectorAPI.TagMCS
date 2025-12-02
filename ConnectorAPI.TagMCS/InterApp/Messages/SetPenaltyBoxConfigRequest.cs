namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Request to update a Layout Configuration on TAG
    /// </summary>
    public class SetPenaltyBoxConfigRequest : Message
    {
        /// <summary>
        /// The Penalty Box Configuration to be set on TAG
        /// </summary>
        public PenaltyBoxData PenaltyBox { get; set; }
    }
}
