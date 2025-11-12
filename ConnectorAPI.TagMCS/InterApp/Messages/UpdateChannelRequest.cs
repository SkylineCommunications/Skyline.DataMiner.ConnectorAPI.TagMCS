namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    public class UpdateChannelRequest : Message
    {
        /// <summary>
        /// The ID of the Channel
        /// </summary>
        public string Channel { get; set; }


        /// <summary>
        /// Constructor for the Get Channel Configuration Request
        /// </summary>
        /// <param name="channel"></param>
        public UpdateChannelRequest(string channel)
        {
            Channel = channel;
        }
    }
}
