// Ignore Spelling: Uuid API
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class ChannelEvents
	{
		[JsonProperty("data")]
		public Datum[] Data { get; set; }

		[JsonProperty("metadata")]
		public ChannelEventsMetadata MetaData { get; set; }
	}

	public class ChannelEventsMetadata
	{
		[JsonProperty("item_count")]
		public int ItemCount { get; set; }

		[JsonProperty("total_items")]
		public int TotalItems { get; set; }

		[JsonProperty("total_pages")]
		public int TotalPages { get; set; }

		[JsonProperty("current_page")]
		public int CurrentPage { get; set; }
	}

	public class Datum
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("channel")]
		public string Channel { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("severity")]
		public string Severity { get; set; }

		[JsonProperty("access_type")]
		public string AccessType { get; set; }

		[JsonProperty("tags")]
		public string[] Tags { get; set; }

		[JsonProperty("timestamp")]
		public DateTime TimeStamp { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("details")]
		public string Details { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("event_type")]
		public string EventType { get; set; }

		[JsonProperty("event_number")]
		public int EventNumber { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("duration")]
		public int? Duration { get; set; }
	}
}
