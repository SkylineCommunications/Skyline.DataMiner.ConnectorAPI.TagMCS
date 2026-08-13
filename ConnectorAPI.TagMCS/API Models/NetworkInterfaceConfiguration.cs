#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class NetworkInterfaceConfigurationData
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("modified")]
        public DateTime Modified { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("iface")]
        public string Iface { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("mask")]
        public string Mask { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("mtu")]
        public string Mtu { get; set; }

        [JsonProperty("flowcontrol")]
        public string FlowControl { get; set; }

        [JsonProperty("igmp")]
        public string Igmp { get; set; }

        [JsonProperty("fec")]
        public string Fec { get; set; }

        [JsonProperty("enable_management")]
        public bool EnableManagement { get; set; }

        [JsonProperty("enable_video_bridge")]
        public bool EnableVideoBridge { get; set; }

        [JsonProperty("management_ttl")]
        public int ManagementTtl { get; set; }

        [JsonProperty("enable_nmos")]
        public bool EnableNmos { get; set; }
    }


    public class NetworkInterfaceConfiguration
    {
        [JsonProperty("data")]
        public List<NetworkInterfaceConfigurationData> Data { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }
}
