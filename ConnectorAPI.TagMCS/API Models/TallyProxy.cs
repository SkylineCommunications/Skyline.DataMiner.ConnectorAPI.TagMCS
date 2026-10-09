#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;

	using Newtonsoft.Json;

	/// <summary>
	/// Wrapper for a GET /tally/proxy list response.
	/// </summary>
	public class TallyProxy
	{
		[JsonProperty("data")]
		public System.Collections.Generic.List<TallyProxyEntry> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	/// <summary>
	/// Wrapper for a single-entry PUT /tally/proxy/:label request/response.
	/// </summary>
	public class TallyProxySingle
	{
		[JsonProperty("data")]
		public TallyProxyEntry Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	/// <summary>
	/// An ad-hoc tally/timer/UMD/image overlay pushed to a device or an active output.
	/// </summary>
	public class TallyProxyEntry
	{
		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("device")]
		public string Device { get; set; }

		[JsonProperty("output")]
		public string Output { get; set; }

		/// <summary>
		/// Gets or sets the duration. Either an integer number of seconds (minimum 5) or the literal string "Permanent".
		/// </summary>
		[JsonProperty("duration")]
		[JsonConverter(typeof(DurationConverter))]
		public string Duration { get; set; }

		[JsonProperty("items")]
		public System.Collections.Generic.List<TallyProxyItem> Items { get; set; }
	}

	/// <summary>
	/// A single polymorphic overlay item. The <see cref="Type"/> discriminator determines which of the
	/// remaining (nullable) fields are relevant: Tally (color, blink), Timer (color, blink, timestamp),
	/// UMD (color, blink, text), Image (url).
	/// </summary>
	public class TallyProxyItem
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("index")]
		public int? Index { get; set; }

		[JsonProperty("color")]
		public string Color { get; set; }

		[JsonProperty("blink")]
		public string Blink { get; set; }

		[JsonProperty("text")]
		public string Text { get; set; }

		[JsonProperty("timestamp")]
		public string Timestamp { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}

	/// <summary>
	/// Request body for a bulk DELETE /tally/proxy call: one entry per target device or output, each with the
	/// labels to remove from that target.
	/// </summary>
	public class DeleteTallyProxyRequest
	{
		[JsonProperty("data")]
		public System.Collections.Generic.List<DeleteTallyProxyEntry> Data { get; set; }
	}

	/// <summary>
	/// One target's worth of labels to delete. Exactly one of <see cref="Device"/>/<see cref="Output"/> should be set.
	/// </summary>
	public class DeleteTallyProxyEntry
	{
		[JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
		public string Device { get; set; }

		[JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
		public string Output { get; set; }

		[JsonProperty("labels")]
		public System.Collections.Generic.List<string> Labels { get; set; }
	}

	/// <summary>
	/// Serializes/deserializes the mixed-type "duration" field (integer seconds, minimum 5, or the literal
	/// string "Permanent") to/from a single string property so the rest of the codebase can treat it uniformly.
	/// </summary>
	public class DurationConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(string);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Integer)
			{
				return Convert.ToString(reader.Value);
			}

			if (reader.TokenType == JsonToken.String)
			{
				return Convert.ToString(reader.Value);
			}

			return null;
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var stringValue = Convert.ToString(value);
			if (int.TryParse(stringValue, out int seconds))
			{
				writer.WriteValue(seconds);
			}
			else
			{
				writer.WriteValue(stringValue);
			}
		}
	}
}
