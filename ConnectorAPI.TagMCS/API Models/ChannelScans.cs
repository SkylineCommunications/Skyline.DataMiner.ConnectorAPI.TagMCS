#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class ChannelScanConfig
	{
		[JsonProperty("data")]
		public List<ScanConfigData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class EditChannelScanConfig
	{
		[JsonProperty("data")]
		public ScanConfigData Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class ScanConfigData
	{
		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("entries")]
		public List<Entry> Entries { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("note")]
		public string Note { get; set; }

		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}

	public class Entry
	{
		[JsonProperty("access_type")]
		public string AccessType { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }

		[JsonProperty("port")]
		public int? Port { get; set; }

		[JsonProperty("source")]
		public string Source { get; set; }

		[JsonProperty("ssm_ip_address")]
		public string SsmIpAddress { get; set; }
	}

	public class ChannelScanStatus
	{
		[JsonProperty("data")]
		public List<ScanStatusData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class ScanStatusData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }

		[JsonProperty("scan")]
		public string Scan { get; set; }

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("progress")]
		public int Progress { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("found")]
		public List<object> Found { get; set; }

		[JsonProperty("added")]
		public List<object> Added { get; set; }

		[JsonProperty("updated")]
		public List<object> Updated { get; set; }

		[JsonProperty("processed")]
		public DateTime Processed { get; set; }

		[JsonProperty("time_remained")]
		public int? TimeRemained { get; set; }

		[JsonProperty("sources")]
		public List<object> Sources { get; set; }
	}

	public class StartChannelScan
	{
		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("existing_channels_action")]
		public string ExistingChannelsAction { get; set; }

		[JsonProperty("missing_channels_action")]
		public string MissingChannelsAction { get; set; }

		[JsonProperty("scan")]
		public string Scan { get; set; }
	}
}
