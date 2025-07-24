#pragma warning disable S4004 // Collection properties should be readonly
#pragma warning disable CS1591 // XML Comments
namespace Skyline.DataMiner.ConnectorAPI.TAGVideoSystems.MCS.API_Models
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;
	using Skyline.DataMiner.Net.Messages.SLDataGateway;

	public class LayoutsConfig
	{
		[JsonProperty("data")]
		public List<Layout> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class SingleLayoutsConfig
	{
		[JsonProperty("data")]
		public Layout Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class Layout
	{
		[JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Created { get; set; }

		[JsonProperty("modified", NullValueHandling = NullValueHandling.Ignore)]
		public DateTime? Modified { get; set; }

		[JsonProperty("background")]
		public string Background { get; set; }

		[JsonProperty("text_mode")]
		public string TextMode { get; set; }

		[JsonProperty("layout_type")]
		public string LayoutType { get; set; }

		[JsonProperty("tiles")]
		public List<Tile> Tiles { get; set; }
	}

	public class Tile
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("tally_source")]
		public object TallySource { get; set; }

		[JsonProperty("channel")]
		public string Channel { get; set; }

		[JsonProperty("show_alarm")]
		public bool ShowAlarm { get; set; }

		[JsonProperty("border_tally_map")]
		public string BorderTallyMap { get; set; }

		[JsonProperty("umd")]
		public List<string> Umd { get; set; }

		[JsonProperty("activation_mode")]
		public string ActivationMode { get; set; }

		[JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
		public string Image { get; set; }

		[JsonProperty("font_size", NullValueHandling = NullValueHandling.Ignore)]
		public object FontSize { get; set; }

		[JsonProperty("text_color", NullValueHandling = NullValueHandling.Ignore)]
		public string TextColor { get; set; }

		[JsonProperty("horizontal_alignment", NullValueHandling = NullValueHandling.Ignore)]
		public string HorizontalAlignment { get; set; }

		[JsonProperty("vertical_alignment", NullValueHandling = NullValueHandling.Ignore)]
		public string VerticalAlignment { get; set; }

		[JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }

		[JsonProperty("timezone", NullValueHandling = NullValueHandling.Ignore)]
		public string Timezone { get; set; }
	}

	public class LayoutsTemplates
	{
		[JsonProperty("data")]
		public List<LayoutTemplate> Data { get; set; }

		[JsonProperty("metadata")]
		public Metadata Metadata { get; set; }
	}

	public class LayoutTemplate
	{
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		[JsonProperty("label")]
		public string Label { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("resolution")]
		public string Resolution { get; set; }

		[JsonProperty("tiles")]
		public List<TemplateTile> Tiles { get; set; }
	}

	public class TemplateTile
	{
		[JsonProperty("index")]
		public int Index { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("x_axis")]
		public int XAxis { get; set; }

		[JsonProperty("y_axis")]
		public int YAxis { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }
	}

	public class LayoutMeta
	{
		[JsonProperty("tiles")]
		public TileMeta Tiles { get; set; }

		[JsonProperty("TextModes")]
		public List<string> TextModes { get; set; }

		[JsonProperty("ContentTypes")]
		public List<string> ContentTypes { get; set; }
	}

	public class TileMeta
	{
		[JsonProperty("text")]
		public TextMeta Text { get; set; }

		[JsonProperty("channel")]
		public ChannelMeta Channel { get; set; }
	}

	public class TextMeta
	{
		[JsonProperty("VerticalAlignments")]
		public List<string> VerticalAlignments { get; set; }

		[JsonProperty("HorizontalAlignments")]
		public List<string> HorizontalAlignments { get; set; }
	}

	public class ChannelMeta
	{
		[JsonProperty("ActivationModes")]
		public List<string> ActivationModes { get; set; }
	}
}
