#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;

	public class NetworksConfiguration
	{
		[JsonProperty("data")]
		public List<NetworkConfigurationData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleNetworkConfiguration
	{
		[JsonProperty("data")]
		public NetworkConfigurationData Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class NetworkConfigurationData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("proxy")]
		public object Proxy { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }
	}

	public class DeleteMultiNetworksConfig
	{
		[JsonProperty("data")]
		public List<string> Data { get; set; }
	}
}
