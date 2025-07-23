namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message to Get the Channel Configuration for a specific channel on TAG
    /// </summary>
    public class GetChannelConfigRequest : Message
    {
        /// <summary>
        /// The ID or Name of the Channel depending on the MessageIdentifier
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// The type of information to be expected in Channel, ID for the id, Name for the name
        /// </summary>
        public MessageIdentifier MessageIdentifier { get; set; }

        /// <summary>
        /// Constructor for the Get Channel Configuration Request
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="messageIdentifier"></param>
        public GetChannelConfigRequest(string channel, MessageIdentifier messageIdentifier)
        {
            Channel = channel;
            MessageIdentifier = messageIdentifier;
        }
    }
}
