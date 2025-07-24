#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class ThresholdConfiguration
	{
		[JsonProperty("data")]
		public List<ThresholdConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class ThresholdConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("entries")]
		public List<ThresholdEntry> Entries { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }
	}

	public class ThresholdEntry
	{
		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("severity")]
		public string Severity { get; set; }

		[JsonProperty("event_rule_id")]
		public int EventRuleId { get; set; }

		[JsonProperty("enable_recording")]
		public bool EnableRecording { get; set; }
	}

	public class Threshold
	{
		[JsonProperty("label")]
		public string Label { get; set; }
	}

	public class ThresholdDeletion
	{
		[JsonProperty("data")]
		public List<string> Data { get; set; }
	}

	public class ThresholdMeta
	{
		[JsonProperty("Severities")]
		public List<string> Severities { get; set; }

		[JsonProperty("Standards")]
		public List<string> Standards { get; set; }

		[JsonProperty("Groups")]
		public List<string> Groups { get; set; }

		[JsonProperty("Rules")]
		public List<ThresholdRules> Rules { get; set; }
	}

	public class ThresholdRules
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("attributes")]
		public ThresholdAttributes Attributes { get; set; }
	}

	public class ThresholdAttributes
	{
		[JsonProperty("group")]
		public string Group { get; set; }

		[JsonProperty("range")]
		public Dictionary<string, string> Range { get; set; }

		[JsonProperty("units")]
		public string Units { get; set; }

		[JsonProperty("caption")]
		public string Caption { get; set; }

		[JsonProperty("standard")]
		public string Standard { get; set; }
	}
}
