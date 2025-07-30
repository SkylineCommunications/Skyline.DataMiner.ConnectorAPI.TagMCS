namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message to Get the Layout Configuration for a specific channel on TAG
    /// </summary>
    public class GetLayoutConfigRequest : Message
    {
        /// <summary>
        /// The ID or Name of the Layout depending on the MessageIdentifier
        /// </summary>
        public string Layout { get; set; }

        /// <summary>
        /// The identifier of the  Layout, ID for the id, Name for the name
        /// </summary>
        public MessageIdentifier MessageIdentifier { get; set; }

        /// <summary>
        /// Constructor for the Get Channel Configuration Request
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="messageIdentifier"></param>
        public GetLayoutConfigRequest(string channel, MessageIdentifier messageIdentifier)
        {
            Layout = channel;
            MessageIdentifier = messageIdentifier;
        }
    }
}
