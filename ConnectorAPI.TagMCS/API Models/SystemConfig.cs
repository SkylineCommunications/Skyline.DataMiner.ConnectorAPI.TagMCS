#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class SystemConfig
	{
		[JsonProperty("data")]
		public List<SysConfigDatum> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SysConfigDatum
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created")]
		public string Created { get; set; }

		[JsonProperty("modified")]
		public string Modified { get; set; }

		[JsonProperty("attributes")]
		public ConfigAttributes Attributes { get; set; }
	}

	public class ConfigAttributes
	{
		[JsonProperty("priority")]
		public string Priority { get; set; }

		[JsonProperty("hosts")]
		public object[] Hosts { get; set; }

		[JsonProperty("local")]
		public bool Local { get; set; }
	}
}
