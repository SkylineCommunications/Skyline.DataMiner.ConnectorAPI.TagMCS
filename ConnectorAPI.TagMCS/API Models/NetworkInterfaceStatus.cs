#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class NetworkInterfaceStatusData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("iface")]
        public string Iface { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("network_label")]
        public string NetworkLabel { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("mask")]
        public string Mask { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("speed")]
        public long? Speed { get; set; }

        [JsonProperty("mac")]
        public string Mac { get; set; }

        [JsonProperty("flowcontrol")]
        public string FlowControl { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("management_enabled")]
        public bool? ManagementEnabled { get; set; }

        [JsonProperty("video_bridge_enabled")]
        public bool? VideoBridgeEnabled { get; set; }

        [JsonProperty("nmos_enabled")]
        public bool? NmosEnabled { get; set; }

        [JsonProperty("up")]
        public bool? Up { get; set; }

        [JsonProperty("rx_multicast_bandwidth")]
        public long? RxMulticastBandwidth { get; set; }

        [JsonProperty("tx_bandwidth")]
        public long? TxBandwidth { get; set; }

        [JsonProperty("rx_bandwidth")]
        public long? RxBandwidth { get; set; }
    }

    public class NetworkInterfaceStatus
    {
        [JsonProperty("data")]
        public List<NetworkInterfaceStatusData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }


}
