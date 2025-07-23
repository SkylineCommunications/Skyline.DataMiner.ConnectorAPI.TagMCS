namespace QAction_1.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class ChannelStatus
	{
		[JsonProperty("data")]
		public List<StatusDatum> Data { get; set; }

		[JsonProperty("metadata")]
		public StatusMetadata Metadata { get; set; }
	}

	public class StatusDatum
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("device")]
		public string Device { get; set; }

		public string DeviceName { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
		public string Thumbnail { get; set; }

		[JsonProperty("timestamp")]
		public DateTimeOffset Timestamp { get; set; }

		[JsonProperty("config")]
		public StatusConfig Config { get; set; }

		[JsonProperty("resources")]
		public Resources Resources { get; set; }

		[JsonProperty("status")]
		public StatusClass Status { get; set; }
	}

	public class StatusConfig
	{
		[JsonProperty("tags")]
		public object[] Tags { get; set; }

		[JsonProperty("access_type")]
		public string AccessType { get; set; }

		[JsonProperty("default_profile")]
		public DefaultProfile DefaultProfile { get; set; }
	}

	public class DefaultProfile
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }
	}

	public class Resources
	{
		[JsonProperty("cpu_used")]
		public long CpuUsed { get; set; }

		[JsonProperty("memory_allocated")]
		public long MemoryAllocated { get; set; }

		[JsonProperty("memory_used")]
		public long MemoryUsed { get; set; }
	}

	public class StatusClass
	{
		[JsonProperty("highest_active_severity")]
		public string HighestActiveSeverity { get; set; }

		[JsonProperty("active_events")]
		public long ActiveEvents { get; set; }

		[JsonProperty("receivers")]
		public List<StatusReceiver> Receivers { get; set; }

		[JsonProperty("components")]
		public List<Component> Components { get; set; }

		[JsonProperty("transport")]
		public Transport Transport { get; set; }
	}

	public class Component
	{
		[JsonProperty("index")]
		public long Index { get; set; }

		[JsonProperty("bitrate")]
		public long Bitrate { get; set; }

		[JsonProperty("monitored")]
		public bool Monitored { get; set; }

		[JsonProperty("content_type")]
		public string ContentType { get; set; }

		[JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
		public string Codec { get; set; }

		[JsonProperty("closed_captions", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> ClosedCaptions { get; set; }

		[JsonProperty("blocking_frame", NullValueHandling = NullValueHandling.Ignore)]
		public long? BlockingFrame { get; set; }

		[JsonProperty("blocking_scene", NullValueHandling = NullValueHandling.Ignore)]
		public long? BlockingScene { get; set; }

		[JsonProperty("motion", NullValueHandling = NullValueHandling.Ignore)]
		public long? Motion { get; set; }

		[JsonProperty("brightness", NullValueHandling = NullValueHandling.Ignore)]
		public long? Brightness { get; set; }

		[JsonProperty("loudness", NullValueHandling = NullValueHandling.Ignore)]
		public Loudness Loudness { get; set; }

		[JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
		public string Language { get; set; }

		[JsonProperty("dolby", NullValueHandling = NullValueHandling.Ignore)]
		public Dolby Dolby { get; set; }

		[JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
		public string Channels { get; set; }

		[JsonProperty("samplerate", NullValueHandling = NullValueHandling.Ignore)]
		public string Samplerate { get; set; }

		[JsonProperty("level_3sec", NullValueHandling = NullValueHandling.Ignore)]
		public double? Level3Sec { get; set; }

		[JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
		public double? Level { get; set; }

		[JsonProperty("truepeak", NullValueHandling = NullValueHandling.Ignore)]
		public double? Truepeak { get; set; }

		[JsonProperty("dial_norm", NullValueHandling = NullValueHandling.Ignore)]
		public long? DialNorm { get; set; }

		[JsonProperty("audio_stat", NullValueHandling = NullValueHandling.Ignore)]
		public string AudioStat { get; set; }

		[JsonProperty("framerate", NullValueHandling = NullValueHandling.Ignore)]
		public string Framerate { get; set; }

		[JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
		public string Resolution { get; set; }

		[JsonProperty("aspect", NullValueHandling = NullValueHandling.Ignore)]
		public string Aspect { get; set; }

		[JsonProperty("colorspace", NullValueHandling = NullValueHandling.Ignore)]
		public string Colorspace { get; set; }

		[JsonProperty("profile_level", NullValueHandling = NullValueHandling.Ignore)]
		public string ProfileLevel { get; set; }

		[JsonProperty("afd", NullValueHandling = NullValueHandling.Ignore)]
		public long? Afd { get; set; }

		[JsonProperty("xds", NullValueHandling = NullValueHandling.Ignore)]
		public Xds Xds { get; set; }

		[JsonProperty("stat_type", NullValueHandling = NullValueHandling.Ignore)]
		public string StatType { get; set; }

		[JsonProperty("gop_struct", NullValueHandling = NullValueHandling.Ignore)]
		public string GopStruct { get; set; }

		[JsonProperty("gop_size", NullValueHandling = NullValueHandling.Ignore)]
		public long? GopSize { get; set; }
	}

	public class Dolby
	{
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("evolution")]
		public string Evolution { get; set; }

		[JsonProperty("intellignet-loudness")]
		public string IntellignetLoudness { get; set; }

		[JsonProperty("channel-coding")]
		public string ChannelCoding { get; set; }

		[JsonProperty("data-rate")]
		public string DataRate { get; set; }

		[JsonProperty("mix-level", NullValueHandling = NullValueHandling.Ignore)]
		public string MixLevel { get; set; }
	}

	public class Loudness
	{
		[JsonProperty("timestamp_us")]
		public long TimestampUs { get; set; }

		[JsonProperty("hourly")]
		public Hourly Hourly { get; set; }

		[JsonProperty("daily", NullValueHandling = NullValueHandling.Ignore)]
		public Daily Daily { get; set; }
	}

	public class Daily
	{
		[JsonProperty("lra")]
		public double Lra { get; set; }

		[JsonProperty("integrated")]
		public double Integrated { get; set; }
	}

	public class Hourly
	{
		[JsonProperty("lra")]
		public double Lra { get; set; }

		[JsonProperty("integrated")]
		public double Integrated { get; set; }

		[JsonProperty("peak")]
		public long Peak { get; set; }
	}

	public class Xds
	{
		[JsonProperty("vchip")]
		public string Vchip { get; set; }

		[JsonProperty("program", NullValueHandling = NullValueHandling.Ignore)]
		public string Program { get; set; }
	}

	public class StatusReceiver
	{
		[JsonProperty("stream_type")]
		public string StreamType { get; set; }

		[JsonProperty("target_duration", NullValueHandling = NullValueHandling.Ignore)]
		public double? TargetDuration { get; set; }

		[JsonProperty("selection")]
		public Selection Selection { get; set; }

		[JsonProperty("manifest-url")]
		public string ManifestUrl { get; set; }

		[JsonProperty("main-profile", NullValueHandling = NullValueHandling.Ignore)]
		public string MainProfile { get; set; }

		[JsonProperty("audio-profile-1", NullValueHandling = NullValueHandling.Ignore)]
		public string AudioProfile1 { get; set; }

		[JsonProperty("audio-profile-2", NullValueHandling = NullValueHandling.Ignore)]
		public string AudioProfile2 { get; set; }

		[JsonProperty("networks")]
		public StatusNetwork[] Networks { get; set; }

		[JsonProperty("program_bitrate")]
		public long ProgramBitrate { get; set; }
	}

	public class StatusNetwork
	{
		[JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
		public string SourceIp { get; set; }

		[JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
		public string SourcePort { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class Selection
	{
		[JsonProperty("found")]
		public bool Found { get; set; }

		[JsonProperty("resolution")]
		public string Resolution { get; set; }

		[JsonProperty("bandwidth")]
		public object Bandwidth { get; set; }

		[JsonProperty("codecs")]
		public string Codecs { get; set; }

		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		[JsonProperty("framerate", NullValueHandling = NullValueHandling.Ignore)]
		public string Framerate { get; set; }
	}

	public class Transport
	{
		[JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
		public long? Bitrate { get; set; }

		[JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
		public string KeyState { get; set; }

		[JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
		public string KeyId { get; set; }

		[JsonProperty("program_cc")]
		public long ProgramCc { get; set; }

		[JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
		public string Resolution { get; set; }
	}

	public class StatusMetadata
	{
		[JsonProperty("item_count")]
		public long ItemCount { get; set; }

		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		[JsonProperty("total_pages")]
		public long TotalPages { get; set; }

		[JsonProperty("current_page")]
		public long CurrentPage { get; set; }
	}
}
