#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	[System.Serializable]
	public class ChannelPathConfigurationRoot
	{
		[JsonProperty("data")]
		public List<ChannelPathConfiguration> ChannelPathConfigurations { get; set; }
	}

	public class SingleChannelPathConfigurationRoot
	{
		[JsonProperty("data")]
		public ChannelPathConfiguration SingleChannelPathConfiguration { get; set; }
	}

	[System.Serializable]
	public class ChannelPathConfiguration
	{
		[JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
		public string Created { get; set; }

		[JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
		public string Modified { get; set; }

		[JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
		public List<Node> Nodes { get; set; }
	}

	[System.Serializable]
	public class Node
	{
		[JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
		public string Channel { get; set; }

		[JsonProperty("x", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int X { get; set; }

		[JsonProperty("y", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int Y { get; set; }

		[JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
		public List<Source> Sources { get; set; }
	}

	[System.Serializable]
	public class Source
	{
		[JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
		public string Channel { get; set; }

		[JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
		public string Label { get; set; }

		[JsonProperty("expected_latency", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int ExpectedLatency { get; set; }
	}
}