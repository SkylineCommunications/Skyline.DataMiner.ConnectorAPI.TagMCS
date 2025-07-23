namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using QAction_1.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message containing the response for the Get Channel Config Request
    /// </summary>
    public class GetChannelConfigResponse : Message
    {
        /// <summary>
        /// Contains the boolean value on whether the request succeeded or not
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Contains any additional information for the response, such as why the request may have failed
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// The Channel Configuration requested, will be null in the case of a failed request
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Constructor for a successful request
        /// </summary>
        /// <param name="channel"></param>
        public GetChannelConfigResponse(Channel channel)
        {
            Channel = channel;
            Success = true;
            ResponseMessage = string.Empty;
        }

        /// <summary>
        /// Constructor for a failed request
        /// </summary>
        /// <param name="responseMessage"></param>
        public GetChannelConfigResponse(string responseMessage)
        {
            ResponseMessage = responseMessage;
            Success = false;
            Channel = null;
        }
    }
}
