#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments

namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Skyline.DataMiner.Net.Notes;

    public class OutputEnableEncoder
    {
        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }
    }

    public class Outputs
    {
        [JsonProperty("data")]
        public List<OutputData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class SingleOutput
    {
        [JsonProperty("data")]
        public OutputData Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class OutputData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("input")]
        public Input Input { get; set; }

        [JsonProperty("config")]
        public OutputConfig Config { get; set; }

        [JsonProperty("processing")]
        public Processing Processing { get; set; }

        [JsonProperty("stream")]
        public OutputStream Stream { get; set; }

        [JsonProperty("groups")]
        public List<Group> Groups { get; set; }
    }

    public class Input
    {
        [JsonProperty("audio")]
        public List<Audio> Audio { get; set; }

        [JsonProperty("layouts")]
        public List<string> Layouts { get; set; }
    }

    public class OutputConfig
    {
        [JsonProperty("audio_alarms", NullValueHandling = NullValueHandling.Ignore)]
        public AudioAlarms AudioAlarms { get; set; }

        [JsonProperty("audio_agent", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioAgent { get; set; }

        [JsonProperty("show_alarms")]
        public bool ShowAlarms { get; set; }

        [JsonProperty("input_loss_mode")]
        public string InputLossMode { get; set; }

        [JsonProperty("audio_display_mode")]
        public string AudioDisplayMode { get; set; }

        [JsonProperty("layout_change_interval")]
        public string LayoutChangeInterval { get; set; }
    }

    public class AudioAlarms
    {
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("critical")]
        public Critical Critical { get; set; }

        [JsonProperty("major")]
        public Major Major { get; set; }

        [JsonProperty("minor")]
        public Minor Minor { get; set; }

        [JsonProperty("warning")]
        public Warning Warning { get; set; }

        [JsonProperty("notice")]
        public Notice Notice { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }
    }

    public class Critical
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Major
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Minor
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Warning
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Notice
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Info
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }

    public class Processing
    {
        [JsonProperty("audio")]
        public List<ProcessingAudio> Audio { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("packaging")]
        public Packaging Packaging { get; set; }

        [JsonProperty("muxing")]
        public Muxing Muxing { get; set; }
    }

    public class OutputStream
    {
        [JsonProperty("senders")]
        public List<Sender> Senders { get; set; }
    }

    public class ProcessingAudio
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }

        /// <summary>
		/// Gets or Sets: From the API, mask can be either "None" or a number between 1 and 32. For writes, we can put null to clear the value.
		/// </summary>
		[JsonProperty("mask")]
        public object Mask { get; set; }
    }

    public class MuxingAudio
    {
        [JsonProperty("pid")]
        public string Pid { get; set; }
    }

    public class Audio
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("audio_pid")]
        public string AudioPid { get; set; }

        [JsonProperty("audio_index")]
        public string AudioIndex { get; set; }
    }

    public class Video
    {
        [JsonProperty("frame_rate")]
        public string FrameRate { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }

        [JsonProperty("interlaced")]
        public bool Interlaced { get; set; }

        [JsonProperty("compression")]
        public Compression Compression { get; set; }
    }

    public class Packaging
    {
        [JsonProperty("min_chunk_length")]
        public int MinChunkLength { get; set; }

        [JsonProperty("number_of_chunks")]
        public int NumberOfChunks { get; set; }

        [JsonProperty("manifest_interval")]
        public string ManifestInterval { get; set; }
    }

    public class Muxing
    {
        [JsonProperty("program_number")]
        public int ProgramNumber { get; set; }

        [JsonProperty("ts_id")]
        public int TsId { get; set; }

        [JsonProperty("pmt_pid")]
        public int PmtPid { get; set; }

        [JsonProperty("video_pid")]
        public int VideoPid { get; set; }

        [JsonProperty("audio")]
        public List<MuxingAudio> Audio { get; set; }
    }

    public class Sender
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("stream_type")]
        public string StreamType { get; set; }

        [JsonProperty("interlaced_mode")]
        public string InterlacedMode { get; set; }

        [JsonProperty("work_mode")]
        public string WorkMode { get; set; }

        [JsonProperty("latency_mode")]
        public string LatencyMode { get; set; }

        [JsonProperty("payload_type")]
        public string PayloadType { get; set; }

        [JsonProperty("networks")]
        public List<OutputNetwork> Networks { get; set; }

        [JsonProperty("transport_mode")]
        public string TransportMode { get; set; }

        [JsonProperty("null_padding")]
        public bool? NullPadding { get; set; }

        [JsonProperty("ts_packets_per_ip_packet")]
        public int? TsPacketsPerIpPacket { get; set; }

        [JsonProperty("low_latency_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LowLatencyMode { get; set; }
    }

    public class Compression
    {
        [JsonProperty("deblocking")]
        public bool Deblocking { get; set; }

        [JsonProperty("downscale")]
        public bool Downscale { get; set; }

        [JsonProperty("ratescale")]
        public bool Ratescale { get; set; }

        [JsonProperty("codec_type")]
        public string CodecType { get; set; }

        [JsonProperty("gop_size")]
        public string GopSize { get; set; }

        [JsonProperty("gop_mode")]
        public string GopMode { get; set; }

        [JsonProperty("hevc_latency_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HevcLatencyMode { get; set; }

        [JsonProperty("vbv_limit")]
        public string VbvLimit { get; set; }

        [JsonProperty("video_bitrate")]
        public long VideoBitrate { get; set; }

        [JsonProperty("jxs_bitrate")]
        public string JxsBitrate { get; set; }
    }

    public class OutputNetwork
    {
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("publish_url")]
        public string PublishUrl { get; set; }
    }

    public class OutputStatus
    {
        [JsonProperty("data")]
        public List<OutputStatusData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class OutputStatusData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("info")]
        public OutputStatusInfo Info { get; set; }

        [JsonProperty("senders")]
        public List<OutputStatusSender> Senders { get; set; }
    }

    public class OutputStatusSender
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("stream_type")]
        public string StreamType { get; set; }

        [JsonProperty("video_bitrate")]
        public long VideoBitrate { get; set; }

        [JsonProperty("total_bitrate")]
        public long TotalBitrate { get; set; }

        [JsonProperty("failed_bitrate")]
        public long FailedBitrate { get; set; }

        [JsonProperty("networks")]
        public List<OutputStatusNetwork> Networks { get; set; }
    }

    public class OutputStatusNetwork
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("network_label")]
        public string NetworkLabel { get; set; }
    }

    public class OutputStatusInfo
    {
        [JsonProperty("active_layout")]
        public string ActiveLayout { get; set; }

        [JsonProperty("encoded_frames")]
        public int EncodedFrames { get; set; }

        [JsonProperty("rendered_frames")]
        public int RenderedFrames { get; set; }

        [JsonProperty("active_sources")]
        public int ActiveSources { get; set; }

        [JsonProperty("thumb")]
        public string Thumb { get; set; }
    }
}