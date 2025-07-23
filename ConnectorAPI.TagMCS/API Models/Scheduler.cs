#pragma warning disable S4004 // Collection properties should be readonly
namespace QAction_1.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class SchedulerConfigurations
	{
		[JsonProperty("data")]
		public List<SchedulerConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleSchedulerConfigurations
	{
		[JsonProperty("data")]
		public SchedulerConfig Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SchedulerConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("note")]
		public string Note { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("attributes")]
		public SchedulerAttributes Attributes { get; set; }
	}

	public class SchedulerAttributes
	{
		[JsonProperty("color")]
		public string Color { get; set; }

		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		[JsonProperty("active_from")]
		public string ActiveFrom { get; set; }

		[JsonProperty("active_until")]
		public string ActiveUntil { get; set; }

		[JsonProperty("entries")]
		public List<SchedulerEntry> Entries { get; set; }

		[JsonProperty("group")]
		public string Group { get; set; }
	}

	public class SchedulerEntry
	{
		[JsonProperty("days_of_week")]
		public List<string> DaysOfWeek { get; set; }

		[JsonProperty("time_of_day")]
		public string TimeOfDay { get; set; }

		[JsonProperty("change_to_profile")]
		public string ChangeToProfile { get; set; }
	}

	public class SchedulerConfigRequest
	{
		[JsonProperty("note")]
		public string Note { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("attributes")]
		public SchedulerAttributesRequest Attributes { get; set; }
	}

	public class SchedulerAttributesRequest
	{
		[JsonProperty("color")]
		public string Color { get; set; }

		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		[JsonProperty("active_from")]
		public DateTime? ActiveFrom { get; set; }

		[JsonProperty("active_until")]
		public DateTime? ActiveUntil { get; set; }

		[JsonProperty("entries")]
		public List<SchedulerEntry> Entries { get; set; }

		[JsonProperty("group")]
		public string Group { get; set; }
	}
}
