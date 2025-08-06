namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message to Get the Output Configuration for a specific channel on TAG
    /// </summary>
    public class GetOutputConfigRequest : Message
    {
        /// <summary>
        /// The ID or Name of the Output depending on the MessageIdentifier
        /// </summary>
        public string Output { get; set; }

        /// <summary>
        /// The type of information to be expected in Channel, ID for the id, Name for the name
        /// </summary>
        public MessageIdentifier MessageIdentifier { get; set; }

        /// <summary>
        /// Constructor for the Get Output Configuration Request
        /// </summary>
        /// <param name="output"></param>
        /// <param name="messageIdentifier"></param>
        public GetOutputConfigRequest(string output, MessageIdentifier messageIdentifier)
        {
            Output = output;
            MessageIdentifier = messageIdentifier;
        }
    }
}
