using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	[JsonObject]
	public sealed class HttpYoutubePlaylist : IYoutubePlaylist, IYoutubeEntity, IEnumerable<IYoutubeVideo>, IEnumerable
	{
		internal YoutubeClient _client;

		[JsonIgnore]
		private List<HttpYoutubeVid> _videos = null;

		[JsonProperty("id")]
		public string Id
		{
			get;
			private set;
		}

		[JsonProperty("snippet")]
		public HttpVidSnippet Snippet
		{
			get;
			private set;
		}

		[JsonProperty("status")]
		public HttpVidStatus PrivacyStatus
		{
			get;
			private set;
		}

		[JsonProperty("contentDetails")]
		public HttpContentDetails ContentDetails
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

		public IReadOnlyList<HttpYoutubeVid> Videos => _videos;

		IVideoSnippet IYoutubePlaylist.Snippet => Snippet;

		IVideoStatus IYoutubePlaylist.PrivacyStatus => PrivacyStatus;

		IContentDetails IYoutubePlaylist.ContentDetails => ContentDetails;

		public IEnumerator<IYoutubeVideo> GetEnumerator()
		{
			return _videos.GetEnumerator();
		}

		public async Task<IReadOnlyList<IYoutubeVideo>> GetVideosAsync()
		{
			if (_videos == null)
			{
				_videos = await _client.GetVideosForPlaylistAsync(Id);
			}
			return _videos;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		internal HttpYoutubePlaylist()
		{
		}
	}
}
