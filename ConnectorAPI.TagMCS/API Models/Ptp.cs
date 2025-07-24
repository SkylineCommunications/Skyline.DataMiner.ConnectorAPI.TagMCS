#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class PtpConfigurations
	{
		[JsonProperty("data")]
		public List<PtpConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SinglePtpConfiguration
	{
		[JsonProperty("data")]
		public PtpConfig Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class PtpConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("groups")]
		public List<string> Groups { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }

		[JsonProperty("working_mode")]
		public string WorkingMode { get; set; }

		[JsonProperty("domain")]
		public int Domain { get; set; }
	}

	public class PtpConfigRequest
	{
		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("working_mode")]
		public string WorkingMode { get; set; }

		[JsonProperty("domain")]
		public int Domain { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }

		[JsonProperty("groups")]
		public List<string> Groups { get; set; }
	}
}
