#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Newtonsoft.Json;

	public class NotificationConfigurations
	{
		[JsonProperty("data")]
		public List<NotificationConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class NotificationConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("entries")]
		public List<NotificationEntry> Entries { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }
	}

	public class NotificationEntry
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("agent")]
		public string Agent { get; set; }

		[JsonProperty("severity")]
		public string Severity { get; set; }
	}
}
