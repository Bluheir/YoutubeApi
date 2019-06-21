using Newtonsoft.Json;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpVidThumbnails : IVideoThumbnails
	{
		[JsonProperty("default")]
		public HttpVidThumbnail Default
		{
			get;
			private set;
		}

		[JsonProperty("medium")]
		public HttpVidThumbnail Medium
		{
			get;
			private set;
		}

		[JsonProperty("high")]
		public HttpVidThumbnail High
		{
			get;
			private set;
		}

		[JsonProperty("standard")]
		public HttpVidThumbnail Standard
		{
			get;
			private set;
		}

		[JsonProperty("maxres")]
		public HttpVidThumbnail MaxRes
		{
			get;
			private set;
		}

		IVideoThumbnail IVideoThumbnails.Default => Default;

		IVideoThumbnail IVideoThumbnails.Medium => Medium;

		IVideoThumbnail IVideoThumbnails.High => High;

		IVideoThumbnail IVideoThumbnails.Standard => Standard;

		IVideoThumbnail IVideoThumbnails.MaxRes => MaxRes;

		internal HttpVidThumbnails()
		{
		}
	}
}
