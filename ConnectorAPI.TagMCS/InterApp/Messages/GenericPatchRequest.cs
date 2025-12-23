namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.InterApp.Messages
{
    using System;

    using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.Helpers;
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    /// <summary>
    /// Inter-app call request message to patch a configuration on the TAG MCS.
    /// </summary>
    public class GenericPatchRequest : Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericPatchRequest"/> class with the specified data to be sent
        /// in a PATCH request.
        /// </summary>
        /// <param name="data">The object containing the data to include in the PATCH request body. The object will be serialized to JSON.
        /// Cannot be <see langword="null"/>.</param>
        /// <param name="endpoint">The API endpoint, used for the URL in the request.</param>
        public GenericPatchRequest(object data, ApiEndpoints endpoint)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            RequestData = DataArrayNormalizer.Normalize(data);
            Endpoint = endpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericPatchRequest"/> class.
        /// </summary>
        /// <remarks>Use this constructor to create a new, empty patch request. Properties can be set
        /// after initialization to define the patch operation.</remarks>
        public GenericPatchRequest() { }

        /// <summary>
        /// The PATCH Configuration to be set on TAG
        /// </summary>
        public string RequestData { get; set; }

        /// <summary>
        /// The endpoint to be set on TAG, used in the driver to translate into the URL for the PATCH.
        /// </summary>
        public ApiEndpoints Endpoint { get; set; }
    }
}
