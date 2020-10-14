using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RestApiTester.Models.Responses
{
	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }
	}

	[XmlRoot(ElementName = "channel")]
	public class Channel
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "language")]
		public string Language { get; set; }
		[XmlElement(ElementName = "ttl")]
		public string Ttl { get; set; }
		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }
		[XmlElement(ElementName = "lastBuildDate")]
		public string LastBuildDate { get; set; }
		[XmlElement(ElementName = "item")]
		public List<Item> Items { get; set; }
	}

	[XmlRoot(ElementName = "rss")]
	public class SearchResponse
	{
		[XmlElement(ElementName = "channel")]
		public Channel Channel { get; set; }
		[XmlAttribute(AttributeName = "version")]
		public string Version { get; set; }
	}
}
