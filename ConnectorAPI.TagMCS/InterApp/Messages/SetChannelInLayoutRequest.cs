using System;
using System.Collections.Generic;
using System.Text;

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message to Set the Channel in the Layout in the Tag MCS
    /// </summary>
    public class SetChannelInLayoutRequest : Message
    {
        /// <summary>
        /// The type of information to be expected in Layout and Channel, ID for the id, Name for the name
        /// </summary>
        public MessageIdentifier MessageIdentifier { get; set; }

        /// <summary>
        /// The Layout to set the Channel on
        /// </summary>
        public string Layout { get; set; }

        /// <summary>
        /// The Channel to set on the Layout
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// The Position in the layout to set to the channel
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Constructor for the Request
        /// </summary>
        /// <param name="layout"></param>
        /// <param name="channel"></param>
        /// <param name="position"></param>
        /// <param name="messageIdentifier"></param>
        public SetChannelInLayoutRequest(string layout, string channel, int position, MessageIdentifier messageIdentifier)
        {
            this.Layout = layout;
            this.Channel = channel;
            this.Position = position;
            this.MessageIdentifier = messageIdentifier;
        }
    }
}
