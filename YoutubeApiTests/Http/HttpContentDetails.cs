using Newtonsoft.Json;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpContentDetails : IContentDetails
	{
		[JsonProperty("duration")]
		public string Duration
		{
			get;
			private set;
		}

		[JsonProperty("dimension")]
		public string Dimension
		{
			get;
			private set;
		}

		[JsonProperty("definition")]
		public string Definition
		{
			get;
			private set;
		}

		[JsonProperty("caption")]
		public string Caption
		{
			get;
			private set;
		}

		[JsonProperty("licensedContent")]
		public bool LicensedContent
		{
			get;
			private set;
		}

		[JsonProperty("projection")]
		public string Projection
		{
			get;
			private set;
		}

		internal HttpContentDetails()
		{
		}
	}
}
