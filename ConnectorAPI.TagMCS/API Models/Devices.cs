#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using Newtonsoft.Json;
	using Skyline.DataMiner.Net.Messages.SLDataGateway;

	public class Access
	{
		public Access(string url, string username, string password)
		{
			Url = url;
			Username = username;
			Password = password;
		}

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }
	}

	public class DeviceData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Created { get; set; }

		[JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Modified { get; set; }

        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Group> Groups { get; set; }

        [JsonProperty("settings")]
		public Settings Settings { get; set; }

		[JsonProperty("access")]
		public Access Access { get; set; }
	}

	public class Group
	{
		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public class DevicesConfig
	{
		[JsonProperty("data")]
		public List<DeviceData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class Settings
	{
		[JsonProperty("color")]
		public List<string> Color { get; set; }

		[JsonProperty("license_sharing")]
		public bool LicenseSharing { get; set; }

		[JsonProperty("stacking_multicast")]
		public string StackingMulticast { get; set; }

		[JsonProperty("stacking_port")]
		public object StackingPort { get; set; }

		[JsonProperty("cloud_license")]
		public string CloudLicense { get; set; }

        [JsonProperty("nielsen_monitoring_license", NullValueHandling = NullValueHandling.Ignore)]
        public object NielsenMonitoringLicense { get; set; }

        [JsonProperty("ssh_admin_password", NullValueHandling = NullValueHandling.Ignore)]
        public object SshAdminPassword { get; set; }

        [JsonProperty("ndi_discovery_servers", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> NdiDiscoveryServers { get; set; }

        [JsonProperty("license_server_host")]
		public List<object> LicenseServerHost { get; set; }

		[JsonProperty("disable_http_access")]
		public bool DisableHttpAccess { get; set; }

		[JsonProperty("disable_ftp_access")]
		public bool DisableFtpAccess { get; set; }

		[JsonProperty("disable_ftps_access")]
		public bool DisableFtpsAccess { get; set; }

        [JsonProperty("nmos", NullValueHandling = NullValueHandling.Ignore)]
        public Nmos Nmos { get; set; }

        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
		public List<Group> Groups { get; set; }
	}

	public class DevicesInformation
	{
		[JsonProperty("data")]
		public List<DeviceInfoData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

    public class Nmos
    {
        [JsonProperty("registration_host")]
        public object RegistrationHost { get; set; }

        [JsonProperty("query_api_port")]
        public object QueryApiPort { get; set; }

        [JsonProperty("verify")]
        public bool Verify { get; set; }
    }

    public class DeviceInfoData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }

		[JsonProperty("uptime")]
		public DateTime Uptime { get; set; }

		[JsonProperty("local")]
		public bool Local { get; set; }

		[JsonProperty("series")]
		public string Series { get; set; }

		[JsonProperty("model")]
		public string Model { get; set; }

		[JsonProperty("serial")]
		public string Serial { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("mode")]
		public string Mode { get; set; }

		[JsonProperty("platform")]
		public string Platform { get; set; }

		[JsonProperty("license")]
		public License License { get; set; }

		[JsonProperty("processed")]
		public DateTime Processed { get; set; }
	}

	public class License
	{
		[JsonProperty("available")]
		public int Available { get; set; }

		[JsonProperty("expiration")]
		public DateTime? Expiration { get; set; }

		[JsonProperty("features")]
		public string Features { get; set; }
	}

	public class Hardware
	{
		public Hardware()
		{
			MemorySlot = new List<string>();
			CpuModel = new List<string>();
			CpuDetails = new List<string>();
			NetworkDevice = new List<string>();
		}

		[JsonProperty("Memory Error Correction")]
		public string MemoryErrorCorrection { get; set; }

		[JsonProperty("Memory Slot")]
		public List<string> MemorySlot { get; set; }

		[JsonProperty("CPU Model")]
		public List<string> CpuModel { get; set; }

		[JsonProperty("CPU Details")]
		public List<string> CpuDetails { get; set; }

		[JsonProperty("BIOS Vendor")]
		public string BiosVendor { get; set; }

		[JsonProperty("BIOS Version")]
		public string BiosVersion { get; set; }

		[JsonProperty("BIOS Release Date")]
		public string BiosReleaseDate { get; set; }

		[JsonProperty("Motherboard Manufacturer")]
		public string MotherboardManufacturer { get; set; }

		[JsonProperty("Motherboard Product Name")]
		public string MotherboardProductName { get; set; }

		[JsonProperty("Motherboard Version")]
		public string MotherboardVersion { get; set; }

		[JsonProperty("Motherboard Serial Number")]
		public string MotherboardSerialNumber { get; set; }

		[JsonProperty("System Manufacturer")]
		public string SystemManufacturer { get; set; }

		[JsonProperty("System Product Name")]
		public string SystemProductName { get; set; }

		[JsonProperty("System Version")]
		public string SystemVersion { get; set; }

		[JsonProperty("System Serial Number")]
		public string SystemSerialNumber { get; set; }

		[JsonProperty("Network Device")]
		public List<string> NetworkDevice { get; set; }
	}

	public class DeviceSingleConfig
	{
		[JsonProperty("data")]
		public DeviceData Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class Channels
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}

	public class Clock
	{
		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("locked")]
		public bool Locked { get; set; }

		[JsonProperty("offset")]
		public double? Offset { get; set; }
	}

	public class Cpu
	{
		[JsonProperty("frequency")]
		public Frequency Frequency { get; set; }

		[JsonProperty("temperature")]
		public List<CpuTemperature> Temperature { get; set; }

		[JsonProperty("used")]
		public double? Used { get; set; }
	}

	public class DeviceStatistics
	{
		[JsonProperty("clock")]
		public Clock Clock { get; set; }

		[JsonProperty("images")]
		public List<Image> Images { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("licenses")]
		public Licenses Licenses { get; set; }

		[JsonProperty("resources")]
		public DeviceResources Resources { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("timestamp")]
		public DateTime? Timestamp { get; set; }

		[JsonProperty("uuid")]
		public string Uuid { get; set; }
	}

	public class Descramblers
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}

	public class Encoders
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}

	public class Frequency
	{
		[JsonProperty("avg")]
		public double? Avg { get; set; }

		[JsonProperty("max")]
		public double? Max { get; set; }

		[JsonProperty("min")]
		public double? Min { get; set; }
	}

	public class Image
	{
		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("firmware")]
		public string Firmware { get; set; }

		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("next")]
		public bool Next { get; set; }

		[JsonProperty("software")]
		public string Software { get; set; }
	}

	public class Licenses
	{
		[JsonProperty("available")]
		public double? Available { get; set; }

		[JsonProperty("limit")]
		public double? Limit { get; set; }

		[JsonProperty("used")]
		public double? Used { get; set; }
	}

	public class Memory
	{
		[JsonProperty("allocated")]
		public int? Allocated { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}

	public class Mlx
	{
		[JsonProperty("temperature")]
		public List<object> Temperature { get; set; }
	}

	public class Recorders
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}

	public class DeviceResources
	{
		[JsonProperty("channels")]
		public Channels Channels { get; set; }

		[JsonProperty("cpu")]
		public Cpu Cpu { get; set; }

		[JsonProperty("descramblers")]
		public Descramblers Descramblers { get; set; }

		[JsonProperty("encoders")]
		public Encoders Encoders { get; set; }

		[JsonProperty("memory")]
		public Memory Memory { get; set; }

		[JsonProperty("mlx")]
		public Mlx Mlx { get; set; }

		[JsonProperty("recorders")]
		public Recorders Recorders { get; set; }

		[JsonProperty("total")]
		public Total Total { get; set; }

		[JsonProperty("uncompressed")]
		public Uncompressed Uncompressed { get; set; }
	}

	public class DecicesStatus
	{
		[JsonProperty("data")]
		public List<DeviceStatistics> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class CpuTemperature
	{
		[JsonProperty("cpu")]
		public int Cpu { get; set; }

		[JsonProperty("temperature")]
		public int Temperature { get; set; }
	}

	public class Total
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public double? Used { get; set; }
	}

	public class Uncompressed
	{
		[JsonProperty("limit")]
		public int? Limit { get; set; }

		[JsonProperty("used")]
		public int? Used { get; set; }
	}
}
