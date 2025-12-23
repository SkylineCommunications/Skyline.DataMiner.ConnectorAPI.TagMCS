namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Represents the response message for the executed PATCH request.
    /// </summary>
    public class GenericPatchResponse : Message
    {
        /// <summary>
        /// Contains the boolean value on whether the request succeeded or not.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Contains any additional information for the response, such as why the request may have failed.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Contains the API response received from TAG upon executing the PATCH request.
        /// If the PATCH failed, this may be null.
        /// </summary>
        public object ApiPatchResponse { get; set; }
    }
}

