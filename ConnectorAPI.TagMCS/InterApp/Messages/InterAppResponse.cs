namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Basic InterApp Response containing the Success of the request and a Response Message containing any additional information
    /// </summary>
    public class InterAppResponse : Message
    {
        /// <summary>
        /// The Success of the request message
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Response Message containing any additional information on the Request
        /// </summary>
        public string ResponseMessage { get; set; }
    }
}
