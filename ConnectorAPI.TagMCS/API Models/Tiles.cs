#pragma warning disable CS1591 // XML Comments

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Tiles
    {
        [JsonProperty("data")]
        public List<TileData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class TileData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("min_width")]
        public int? MinWidth { get; set; }

        [JsonProperty("min_height")]
        public int? MinHeight { get; set; }

        [JsonProperty("default_width")]
        public int? DefaultWidth { get; set; }

        [JsonProperty("default_height")]
        public int? DefaultHeight { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("objects")]
        public List<Object> Objects { get; set; }
    }

    public class Object
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("left")]
        public Left Left { get; set; }

        [JsonProperty("right")]
        public Right Right { get; set; }

        [JsonProperty("top")]
        public Top Top { get; set; }

        [JsonProperty("bottom")]
        public Bottom Bottom { get; set; }

        [JsonProperty("max_width")]
        public MaxWidth MaxWidth { get; set; }

        [JsonProperty("max_height")]
        public MaxHeight MaxHeight { get; set; }

        [JsonProperty("alignment")]
        public string Alignment { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("crop")]
        public Crop Crop { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("thickness")]
        public int? Thickness { get; set; }

        [JsonProperty("default_value")]
        public object DefaultValue { get; set; }
    }

    public class Right
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }

    public class Top
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }

    public class Bottom
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }

    public class Crop
    {
        [JsonProperty("left")]
        public Left Left { get; set; }

        [JsonProperty("right")]
        public Right Right { get; set; }

        [JsonProperty("top")]
        public Top Top { get; set; }

        [JsonProperty("bottom")]
        public Bottom Bottom { get; set; }
    }

    public class Left
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }

    public class MaxHeight
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }

    public class MaxWidth
    {
        [JsonProperty("pixels")]
        public int? Pixels { get; set; }

        [JsonProperty("percentage")]
        public double? Percentage { get; set; }
    }
}