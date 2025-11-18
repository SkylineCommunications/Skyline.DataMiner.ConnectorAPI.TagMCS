#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;

	public class DnsConfigurations
	{
		[JsonProperty("data")]
		public List<DnsConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleDnsConfiguration
	{
		[JsonProperty("data")]
		public DnsConfig Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class DnsConfig
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

		[JsonProperty("host")]
		public string Host { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }
	}

	public class DnsConfigRequest
	{
		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("host")]
		public string Host { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }

		[JsonProperty("groups")]
		public List<string> Groups { get; set; }
	}
}
