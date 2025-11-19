#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;

    public class PenaltyBoxAttributes
    {
        [JsonProperty("min_display_time")]
        public int MinDisplayTime { get; set; }

        [JsonProperty("decay_after_clear")]
        public int DecayAfterClear { get; set; }

        [JsonProperty("severities")]
        public List<string> Severities { get; set; }
    }

    public class PenaltyBoxData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("sources")]
        public List<PenaltyBoxSource> Sources { get; set; }

        [JsonProperty("destinations")]
        public List<PenaltyBoxDestination> Destinations { get; set; }

        [JsonProperty("attributes")]
        public PenaltyBoxAttributes Attributes { get; set; }
    }

    public class PenaltyBoxDestination
    {
        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class PenaltyBoxConfiguration
    {
        [JsonProperty("data")]
        public List<PenaltyBoxData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class PenaltyBoxSource
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }
    }


}
