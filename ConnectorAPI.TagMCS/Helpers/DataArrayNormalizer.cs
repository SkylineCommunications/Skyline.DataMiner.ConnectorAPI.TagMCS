namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.Helpers
{
    using System;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A normalizer to ensure the incoming object contains the
    /// data array required for PATCH requests.
    /// </summary>
    public static class DataArrayNormalizer
    {
        /// <summary>
        /// Ensures the object is wrapped inside a data array.
        /// </summary>
        /// <param name="payload">The object/class to verify.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string Normalize(object payload)
        {
            if (payload == null) throw new ArgumentNullException(nameof(payload));

            var token = JToken.FromObject(payload);

            if (token.Type != JTokenType.Object)
            {
                return Wrap(token).ToString(Formatting.None);
            }

            var obj = (JObject)token;

            if (!obj.TryGetValue("data", out var dataToken) || dataToken == null || dataToken.Type == JTokenType.Null)
            {
                return Wrap(obj).ToString(Formatting.None);
            }

            if (dataToken.Type == JTokenType.Array)
            {
                return obj.ToString(Formatting.None);
            }

            obj["data"] = new JArray(dataToken);

            return obj.ToString(Formatting.None);
        }

        private static JObject Wrap(JToken token)
        {
            return new JObject
            {
                ["data"] = new JArray(token)
            };
        }
    }

}
