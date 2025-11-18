#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class TimezoneConfigurations
	{
		[JsonProperty("data")]
		public List<TimezoneConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleTimezoneConfiguration
	{
		[JsonProperty("data")]
		public TimezoneConfig Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class TimezoneConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("utc_offset")]
		public int UtcOffset { get; set; }

		[JsonProperty("daylight_saving")]
		public List<DaylightSaving> DaylightSaving { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }
	}

	public class DaylightSaving
	{
		[JsonProperty("dst_offset")]
		public int DstOffset { get; set; }

		[JsonProperty("utc_start")]
		public DateTime UtcStart { get; set; }

		[JsonProperty("utc_end")]
		public DateTime UtcEnd { get; set; }
	}

	public class TimezoneConfigRequest
	{

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("utc_offset")]
		public int UtcOffset { get; set; }

		[JsonProperty("daylight_saving")]
		public List<DaylightSaving> DaylightSaving { get; set; }
	}
}
