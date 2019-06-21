using Newtonsoft.Json;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpVidThumbnail : IVideoThumbnail
	{
		[JsonProperty("url")]
		public string Url
		{
			get;
			private set;
		}

		[JsonProperty("width")]
		public uint Width
		{
			get;
			private set;
		}

		[JsonProperty("height")]
		public uint Height
		{
			get;
			private set;
		}

		internal HttpVidThumbnail()
		{
		}
	}
}
