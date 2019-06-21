using Newtonsoft.Json;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpVidStatus : IVideoStatus
	{
		[JsonProperty("uploadStatus")]
		public string UploadStatus
		{
			get;
			private set;
		}

		[JsonProperty("privacyStatus")]
		public string PrivacyStatus
		{
			get;
			private set;
		}

		[JsonProperty("license")]
		public string License
		{
			get;
			private set;
		}

		[JsonProperty("embeddable")]
		public bool Embeddable
		{
			get;
			private set;
		}

		[JsonProperty("publicStatsViewable")]
		public bool PublicStatsViewable
		{
			get;
			private set;
		}

		internal HttpVidStatus()
		{
		}
	}
}
