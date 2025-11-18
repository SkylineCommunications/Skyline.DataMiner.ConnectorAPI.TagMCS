#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using Newtonsoft.Json;

    public class SystemStatus
	{
		[JsonProperty("data")]
		public SystemDatum[] Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SystemDatum
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
		public string Timestamp { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("local")]
		public bool Local { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("applications")]
		public Application[] Applications { get; set; }
	}

	public class Application
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}