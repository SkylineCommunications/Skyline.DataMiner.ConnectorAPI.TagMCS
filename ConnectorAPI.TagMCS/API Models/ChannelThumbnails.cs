#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using Newtonsoft.Json;

    public class ChannelThumbnails
    {
        [JsonProperty("data")]
        public ThumbnailData Data { get; set; }

        [JsonProperty("metadata")]
        public StatusMetadata Metadata { get; set; }
    }

    public class ThumbnailData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("thumb")]
        public string Thumbnail { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}
