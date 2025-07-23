#pragma warning disable CS1591 // XML Comments
namespace QAction_1.HelperClasses
{
	using System;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;

	[JsonConverter(typeof(StringOrIntConverter))]
	public class StringOrInt
	{
		public string StringValue { get; }

		public int? IntValue { get; }

		public bool IsString { get; }

		public StringOrInt(string value)
		{
			StringValue = value;
			IsString = true;
		}

		public StringOrInt(int value)
		{
			IntValue = value;
			IsString = false;
		}

		public override string ToString()
		{
			return IsString ? StringValue : IntValue?.ToString();
		}
	}

	public class StringOrIntConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(StringOrInt);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				return null;
			}

			var token = JToken.Load(reader);
			if (token.Type == JTokenType.String)
			{
				return new StringOrInt(token.ToString());
			}
			else if (token.Type == JTokenType.Integer)
			{
				return new StringOrInt(token.ToObject<int>());
			}
			else
			{
				// Nothing to do
			}

			throw new JsonSerializationException($"Unexpected token type: {token.Type}");
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			var stringOrInt = (StringOrInt)value;
			if (stringOrInt.IsString)
			{
				writer.WriteValue(stringOrInt.StringValue);
			}
			else
			{
				writer.WriteValue(stringOrInt.IntValue);
			}
		}
	}
}
