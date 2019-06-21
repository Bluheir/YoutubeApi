using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using YoutubeApiTest.Models;
using YoutubeApiTests.Methods;

namespace YoutubeApiTest.Http
{
	[Serializable]
	public sealed class HttpYoutubeVid : IYoutubeVideo, IYoutubeEntity
	{
		[NonSerialized]
		[JsonIgnore]
		internal YoutubeClient _client;

		[JsonProperty("id")]
		public string Id
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

		[JsonProperty("snippet")]
		public HttpVidSnippet Snippet
		{
			get;
			private set;
		}

		[JsonIgnore]
		IVideoSnippet IYoutubeVideo.Snippet => Snippet;

		[JsonProperty("statistics")]
		public HttpVidStatistics Statistics
		{
			get;
			private set;
		}

		IVideoStatistics IYoutubeVideo.Statistics => Statistics;

		[JsonProperty("contentDetails")]
		public HttpContentDetails ContentDetails
		{
			get;
			private set;
		}

		[JsonIgnore]
		IContentDetails IYoutubeVideo.ContentDetails => ContentDetails;

		[JsonProperty("status")]
		public HttpVidStatus PrivacyStatus
		{
			get;
			private set;
		}

		[JsonIgnore]
		IVideoStatus IYoutubeVideo.PrivacyStatus => PrivacyStatus;

		[JsonProperty("etag")]
		public string Etag
		{
			get;
			private set;
		}

		public async Task<bool> DownloadThumnailAsync(string filePath, ThumbnailType thumbnailType = ThumbnailType.MaxRes)
		{
			if (filePath == null)
			{
				return false;
			}
			HttpVidThumbnails thumbnails = Snippet.Thumbnails;
			string url;
			switch (thumbnailType)
			{
			case ThumbnailType.Default:
				url = thumbnails.Default.Url;
				break;
			case ThumbnailType.High:
				url = thumbnails.High.Url;
				break;
			case ThumbnailType.Medium:
				url = thumbnails.Medium.Url;
				break;
			case ThumbnailType.Standard:
				url = thumbnails.Standard.Url;
				break;
			default:
				url = thumbnails.MaxRes.Url;
				break;
			}
			try
			{
				await FileMethods.WriteBytesAsync(filePath, await _client.GetBytesAsync(url));
			}
			catch
			{
				return false;
			}
			return true;
		}

		public async Task DownloadVideoAsync(string filePath)
		{
			await FileMethods.WriteBytesAsync(filePath, await _client.GetVideoBytesAsync(Id));
		}

		public async Task<byte[]> GetVideoBytesAsync()
		{
			return await _client.GetVideoBytesAsync(Id);
		}

		internal HttpYoutubeVid()
		{
		}
	}
}
