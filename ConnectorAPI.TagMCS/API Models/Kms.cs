#pragma warning disable S4004 // Collection properties should be readonly
namespace QAction_1.API_Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Newtonsoft.Json;
	using Skyline.DataMiner.Net.Messages.SLDataGateway;

	public class KmsConfigurations
	{
		[JsonProperty("data")]
		public List<KmsConfig> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleKmsConfiguration
	{
		[JsonProperty("data")]
		public KmsConfig Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class KmsConfig
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("kms_type")]
		public string KmsType { get; set; }

		[JsonProperty("attributes")]
		public KmsAttributes Attributes { get; set; }
	}

	public class KmsAttributes
	{
		[JsonProperty("protection_info_url")]
		public string ProtectionInfoUrl { get; set; }

		[JsonProperty("asset_ids")]
		public List<string> AssetIds { get; set; }

		[JsonProperty("network")]
		public string Network { get; set; }

		[JsonProperty("certificate")]
		public string Certificate { get; set; }

		[JsonProperty("port")]
		public int Port { get; set; }

		[JsonProperty("download_rate")]
		public string DownloadRate { get; set; }

		[JsonProperty("tenant_id")]
		public string TenantId { get; set; }

		[JsonProperty("management_key")]
		public string ManagmentKey { get; set; }

		[JsonProperty("protection_info_credentials_url")]
		public string ProtectionInfoCredentialsUrl { get; set; }

		[JsonProperty("public_key")]
		public string PublicKey { get; set; }

		[JsonProperty("session_key")]
		public string SessionKey { get; set; }

		[JsonProperty("host_url")]
		public string HostUrl { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }

		[JsonProperty("token_request_url")]
		public string TokenRequestUrl { get; set; }

		[JsonProperty("grant_type")]
		public string GrantType { get; set; }

		[JsonProperty("audience")]
		public string Audience { get; set; }

		[JsonProperty("client_id")]
		public string ClientId { get; set; }

		[JsonProperty("realm")]
		public string Realm { get; set; }

		[JsonProperty("private_key")]
		public string PrivateKey { get; set; }

		[JsonProperty("query")]
		public string Query { get; set; }

		[JsonProperty("options")]
		public string Options { get; set; }

		[JsonProperty("keys")]
		public List<string> Keys { get; set; }

		[JsonProperty("source_url_token")]
		public string SourceUrlToken { get; set; }

		[JsonProperty("replace_url_token")]
		public string ReplaceUrlToken { get; set; }

		[JsonProperty("token")]
		public string Token { get; set; }
	}
}
