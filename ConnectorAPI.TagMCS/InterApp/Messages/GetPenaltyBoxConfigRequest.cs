namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message to Get the Layout Configuration for a specific channel on TAG
    /// </summary>
    public class GetPenaltyBoxConfigRequest : Message
    {
        /// <summary>
        /// The ID or Name of the Layout depending on the MessageIdentifier
        /// </summary>
        public string PenaltyBox { get; set; }

        /// <summary>
        /// The identifier of the  Layout, ID for the id, Name for the name
        /// </summary>
        public MessageIdentifier MessageIdentifier { get; set; }

        /// <summary>
        /// Constructor for the Get Layout Configuration Request
        /// </summary>
        /// <param name="penaltyBox"></param>
        /// <param name="messageIdentifier"></param>
        public GetPenaltyBoxConfigRequest(string penaltyBox, MessageIdentifier messageIdentifier)
        {
            PenaltyBox = penaltyBox;
            MessageIdentifier = messageIdentifier;
        }
    }
}