#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Newtonsoft.Json;

	public class SystemFiles
	{
		[JsonProperty("data")]
		public List<SystemFileData> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SystemFileData
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("filename")]
		public string Filename { get; set; }

		[JsonProperty("ext")]
		public string Ext { get; set; }

		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("attributes")]
		public FileAttributes Attributes { get; set; }
	}

	public class FileAttributes
	{
		[JsonProperty("file_type")]
		public string FileType { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("timestamp")]
		public DateTime Timestamp { get; set; }

		[JsonProperty("postgres_client")]
		public double PostgresClient { get; set; }

		[JsonProperty("postgres_server")]
		public double PostgresServer { get; set; }
	}
}
