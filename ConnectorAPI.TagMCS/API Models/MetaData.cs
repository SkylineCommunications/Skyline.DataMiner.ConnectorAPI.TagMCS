namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Metadata
    {
        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("sort_by")]
        public List<SortBy> SortBy { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }
}
