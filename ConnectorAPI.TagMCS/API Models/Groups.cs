#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Groups
    {
        [JsonProperty("data")]
        public List<GroupsData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class GroupsData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("modified")]
        public DateTime? Modified { get; set; }

        [JsonProperty("type")]
        public List<string> Type { get; set; }

        [JsonProperty("children")]
        public List<string> Children { get; set; }
    }
}
