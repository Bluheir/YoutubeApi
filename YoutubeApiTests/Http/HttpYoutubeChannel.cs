using Newtonsoft.Json;
using System.Threading.Tasks;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public class HttpYoutubeChannel : IYoutubeChannel, IYoutubeEntity
	{
		[JsonProperty("snippet")]
		public HttpVidSnippet Snippet
		{
			get;
			private set;
		}

		[JsonProperty("id")]
		public string Id
		{
			get;
			private set;
		}

		[JsonProperty("contentDetails")]
		public IChannelContentDetails ContentDetails
		{
			get;
			private set;
		}

		public IChannelStatistics Statistics
		{
			get;
			private set;
		}

		public ITopicDetails TopicDetails
		{
			get;
			private set;
		}

		public IChannelStatus Status
		{
			get;
			private set;
		}

		public IBrandingChannel BrandingSettings
		{
			get;
			private set;
		}

		[JsonProperty("ownerDetails")]
		public IContentOwnerDetails OwnerDetails
		{
			get;
			private set;
		}

		[JsonProperty("etag")]
		public string Etag
		{
			get;
			private set;
		}

		[JsonProperty("kind")]
		public string Kind
		{
			get;
			private set;
		}

		IVideoSnippet IYoutubeChannel.Snippet => Snippet;

		internal HttpYoutubeChannel()
		{
		}

		public async Task<IYoutubePlaylist> GetUploadedVideosAsync()
		{
			return null;
		}
	}
}
