namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Message containing the response for the Get Output Config Request
    /// </summary>
    public class GetOutputConfigResponse : Message
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
        /// The Output Configuration requested, will be null in the case of a failed request
        /// </summary>
        public OutputData Output { get; set; }
    }
}
