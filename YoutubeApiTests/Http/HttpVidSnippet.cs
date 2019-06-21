using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpVidSnippet : IVideoSnippet
	{
		[JsonProperty("tags")]
		private List<string> _tags;

		[JsonProperty("publishedAt")]
		public string PublishedAt
		{
			get;
			private set;
		}

		[JsonProperty("channelId")]
		public string ChannelId
		{
			get;
			private set;
		}

		[JsonProperty("title")]
		public string Title
		{
			get;
			private set;
		}

		[JsonProperty("channelTitle")]
		public string ChannelTitle
		{
			get;
			private set;
		}

		[JsonProperty("description")]
		public string Description
		{
			get;
			private set;
		}

		[JsonProperty("liveBroadcastContent")]
		public string LiveBroadcastContent
		{
			get;
			private set;
		}

		[JsonProperty("thumbnails")]
		public HttpVidThumbnails Thumbnails
		{
			get;
			private set;
		}

		IVideoThumbnails IVideoSnippet.Thumbnails => Thumbnails;

		[JsonProperty("categoryId")]
		public string CategoryId
		{
			get;
			private set;
		}

		[JsonIgnore]
		public IReadOnlyList<string> Tags => _tags;

		internal HttpVidSnippet()
		{
		}
	}
}
