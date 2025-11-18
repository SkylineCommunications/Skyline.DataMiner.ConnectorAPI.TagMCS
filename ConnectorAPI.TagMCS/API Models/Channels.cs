#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;

	using Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.HelperClasses;

	public class ChannelMonitoring
	{
		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("channel")]
		public string Channel { get; set; }
	}

	public class ChannelsConfig
	{
		[JsonProperty("data")]
		public List<Channel> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class Channel
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("access_type")]
		public string AccessType { get; set; }

		[JsonProperty("service_type")]
		public string ServiceType { get; set; }

		[JsonProperty("recording_enabled")]
		public bool? RecordingEnabled { get; set; }

		[JsonProperty("fingerprinting_enabled")]
		public bool? FingerprintigEnabled { get; set; }

		[JsonProperty("descrambling_enabled")]
		public bool? DescramblingEnabled { get; set; }

		[JsonProperty("note")]
		public string Note { get; set; }

		[JsonProperty("config")]
		public Config Config { get; set; }

        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Groups { get; set; }

        [JsonProperty("receivers")]
		public List<Receiver> Receivers { get; set; }

		[JsonProperty("profiles")]
		public List<Profile> Profiles { get; set; }

		[JsonProperty("variants")]
		public List<Channel> Variants { get; set; }
	}

	public class Config
	{
		[JsonProperty("tally_settings")]
		public string TallySettings { get; set; }

		[JsonProperty("audio_monitoring_standard")]
		public string AudioMonitoringStandard { get; set; }

		[JsonProperty("snooze_on_profile_change")]
		public int SnoozeOnProfileChange { get; set; }

		[JsonProperty("st2038_mode")]
		public string St2038Mode { get; set; }

		[JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
		public List<string> Tags { get; set; }

		[JsonProperty("unconfigured_components_behavior")]
		public string UnconfiguredComponentsBehavior { get; set; }

		[JsonProperty("hide_overscan")]
		public bool HideOverscan { get; set; }

		[JsonProperty("monitoring_level")]
		public string MonitoringLevel { get; set; }

		[JsonProperty("activation_group")]
		public string ActivationGroup { get; set; }

		[JsonProperty("scheduling_group")]
		public string SchedulingGroup { get; set; }

		[JsonProperty("ts_standard_type")]
		public string TsStandardType { get; set; }

		[JsonProperty("rtp_mode")]
		public string RtpMode { get; set; }

		[JsonProperty("ts_id")]
		public StringOrInt TsId { get; set; }

		[JsonProperty("ts_services")]
		public StringOrInt TsServices { get; set; }

		[JsonProperty("ts_bitrate")]
		public StringOrInt TsBitrate { get; set; }

		[JsonProperty("scheduling_mode")]
		public string SchedulingMode { get; set; }

		[JsonProperty("version")]
		public string HlsVersion { get; set; }

		[JsonProperty("encrypted")]
		public bool Encrypted { get; set; }

		[JsonProperty("max_chunk_duration")]
		public string ChunkDurationMax { get; set; }

		[JsonProperty("min_chunk_duration")]
		public string ChunkDurationMin { get; set; }

		[JsonProperty("content")]
		public Content Content { get; set; }
	}

	public class Content
	{
		[JsonProperty("sdt_name")]
		public string SdtName { get; set; }

		[JsonProperty("sdt_provider")]
		public string SdtProvider { get; set; }

		[JsonProperty("nit_carrier_encoder_manufacturer")]
		public string NitCarrierEncoderManufacturer { get; set; }

		[JsonProperty("nit_carrier_encoder_serial_number")]
		public string NitCarrierEncoderSerialNumber { get; set; }

		[JsonProperty("nit_carrier_identifier")]
		public string NitCarrierIdentifier { get; set; }

		[JsonProperty("nit_carrier_telephone_number")]
		public string NitCarrierTelephoneNumber { get; set; }

		[JsonProperty("nit_carrier_longitude")]
		public string NitCarrierLongitude { get; set; }

		[JsonProperty("nit_carrier_latitude")]
		public string NitCarrierLatitude { get; set; }

		[JsonProperty("nit_carrier_user_information")]
		public string NitCarrierUserInformation { get; set; }
	}

	public class Receiver
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("variant_url")]
		public string VariantUrl { get; set; }

		[JsonProperty("variant_index")]
		public string VariantIndex { get; set; }

		[JsonProperty("payload_type")]
		public string PayloadType { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("stream_identifier")]
		public string StreamIdentifier { get; set; }

		[JsonProperty("stream_id")]
		public string StreamId { get; set; }

		[JsonProperty("stream_type")]
		public string StreamType { get; set; }

		[JsonProperty("codec_type")]
		public string CodecType { get; set; }

		[JsonProperty("session_ttl")]
		public string SessionTtl { get; set; }

		[JsonProperty("delay")]
		public string Delay { get; set; }

		[JsonProperty("asset_id")]
		public string AssetId { get; set; }

		[JsonProperty("t2mi_plp")]
		public string T2MiPlp { get; set; }

		[JsonProperty("encryption_type")]
		public string EncryptionType { get; set; }

		[JsonProperty("encryption_constant_cw")]
		public string EncryptionConstantCw { get; set; }

		[JsonProperty("kms")]
		public string Kms { get; set; }

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }

		[JsonProperty("program_number")]
		public string ProgramNumber { get; set; }

		[JsonProperty("attributes")]
		public ReceiverAttributes Attributes { get; set; }

		[JsonProperty("networks")]
		public List<Network> Networks { get; set; }
	}

	public class ReceiverAttributes
	{
		[JsonProperty("audio")]
		public string Audio { get; set; }

		[JsonProperty("bandwidth")]
		public int? Bandwidth { get; set; }

		[JsonProperty("codecs")]
		public string Codecs { get; set; }

		[JsonProperty("frame_rate")]
		public string FrameRate { get; set; }

		[JsonProperty("resolution")]
		public string Resolution { get; set; }
	}

	public class Network
	{
		[JsonProperty("network")]
		public string NetworkId { get; set; }

		[JsonProperty("ip_address")]
		public string IpAddress { get; set; }

		[JsonProperty("ssm_ip_address")]
		public string SsmIpAddress { get; set; }

		[JsonProperty("port")]
		public int? Port { get; set; }
	}

	public class Profile
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("notification")]
		public string Notification { get; set; }

		[JsonProperty("threshold")]
		public string Threshold { get; set; }

		[JsonProperty("default")]
		public bool Default { get; set; }

		[JsonProperty("title_color")]
		public string TitleColor { get; set; }

		[JsonProperty("border_color")]
		public string BorderColor { get; set; }

		[JsonProperty("pixelate_level")]
		public object PixelateLevel { get; set; }

		[JsonProperty("service_bitrate_min")]
		public string ServiceBitrateMin { get; set; }

		[JsonProperty("service_bitrate_max")]
		public string ServiceBitrateMax { get; set; }

		[JsonProperty("rst_running_state")]
		public string RstRunningState { get; set; }

		[JsonProperty("components")]
		public List<ProfileComponent> Components { get; set; }

		[JsonProperty("mapping")]
		public List<Mapping> Mapping { get; set; }
	}

	public class Mapping
	{
		[JsonProperty("content_type")]
		public string ContentType { get; set; }

		[JsonProperty("receiver")]
		public MappingReceiver Receiver { get; set; }

		[JsonProperty("template")]
		public MappingTemplate Template { get; set; }

		[JsonProperty("display")]
		public MappingDisplay Display { get; set; }
	}

	public class MappingReceiver
	{
		[JsonProperty("pid")]
		public int? Pid { get; set; }

		[JsonProperty("page")]
		public int? Page { get; set; }

		[JsonProperty("index")]
		public string Index { get; set; }

		[JsonProperty("layout")]
		public string Layout { get; set; }

		[JsonProperty("channels")]
		public List<AudioChannel> Channels { get; set; }
	}

	public class MappingTemplate
	{
		[JsonProperty("index")]
		public string Index { get; set; }
	}

	public class AudioChannel
	{
		[JsonProperty("channel")]
		public int Channel { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("order")]
		public int Order { get; set; }
	}

	public class MappingDisplay
	{
		[JsonProperty("index")]
		public string Index { get; set; }

		[JsonProperty("closed_caption")]
		public string ClosedCaption { get; set; }
	}

	public class ProfileComponent
	{
		[JsonProperty("content_type")]
		public string ContentType { get; set; }

		[JsonProperty("pid")]
		public int? Pid { get; set; }

		[JsonProperty("monitored")]
		public bool? Monitored { get; set; }

		[JsonProperty("content_monitored")]
		public bool? ContentMonitored { get; set; }

		[JsonProperty("scrambled")]
		public bool? Scrambled { get; set; }

		[JsonProperty("contain_pcr")]
		public bool? ContainPcr { get; set; }

		[JsonProperty("bitrate_min")]
		public string BitrateMin { get; set; }

		[JsonProperty("bitrate_max")]
		public string BitrateMax { get; set; }

		[JsonProperty("out_of_band")]
		public bool? OutOfBand { get; set; }

		[JsonProperty("descriptors_hash")]
		public string DescriptorsHash { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("codec_type")]
		public string CodecType { get; set; }

		[JsonProperty("resolution")]
		public string Resolution { get; set; }

		[JsonProperty("aspect_ratio")]
		public string AspectRatio { get; set; }

		[JsonProperty("profile")]
		public string Profile { get; set; }

		[JsonProperty("color_space")]
		public string ColorSpace { get; set; }

		[JsonProperty("frame_rate")]
		public string FrameRate { get; set; }

		[JsonProperty("language")]
		public string Language { get; set; }

		[JsonProperty("channels")]
		public string Channels { get; set; }

		[JsonProperty("dial_norm")]
		public string DialNorm { get; set; }

		[JsonProperty("samplerate")]
		public string Samplerate { get; set; }

		[JsonProperty("vendor_id")]
		public string VendoId { get; set; }

		[JsonProperty("private_data")]
		public string PrivateData { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("bits_per_sample")]
		public string BitPerSample { get; set; }

		[JsonProperty("dolby_channels")]
		public string DolbyChannels { get; set; }

		[JsonProperty("page")]
		public int? Page { get; set; }
	}
}
