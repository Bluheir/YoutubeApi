using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public class YoutubeClient : IDisposable
	{
		private HttpClient _client;

		private string _key;

		private bool _disposed;

		private const string BaseUri = "https://www.googleapis.com/youtube/v3/";

		public YoutubeClient(string apiKey)
		{
			_disposed = false;
			_client = new HttpClient();
			_key = apiKey;
		}

		public async Task<IYoutubeVideo> GetVideoAsync(string videoId)
		{
			HttpYTSearchResult<HttpYoutubeVid> value = JsonConvert.DeserializeObject<HttpYTSearchResult<HttpYoutubeVid>>(await _client.GetStringAsync("https://www.googleapis.com/youtube/v3/videos?id=" + videoId + "&key=" + _key + "&part=snippet,contentDetails,statistics,status"));
			HttpYoutubeVid t = value.Results[0];
			t._client = this;
			return t;
		}

		public async Task<IYoutubePlaylist> GetPlaylistAsync(string playlistId)
		{
			HttpYTSearchResult<HttpYoutubePlaylist> value = JsonConvert.DeserializeObject<HttpYTSearchResult<HttpYoutubePlaylist>>(await _client.GetStringAsync("https://www.googleapis.com/youtube/v3/playlists?id=" + playlistId + "&key=" + _key + "&part=contentDetails,snippet,status"));
			HttpYoutubePlaylist result = value.Results[0];
			result._client = this;
			foreach (IYoutubeVideo video in await result.GetVideosAsync())
			{
				(video as HttpYoutubeVid)._client = this;
			}
			return result;
		}

		internal async Task<byte[]> GetBytesAsync(string website)
		{
			return await _client.GetByteArrayAsync(website);
		}

		internal async Task<List<HttpYoutubeVid>> GetVideosForPlaylistAsync(string playlistId)
		{
			HttpYTSearchResult<HttpYoutubeVid> value = JsonConvert.DeserializeObject<HttpYTSearchResult<HttpYoutubeVid>>(await _client.GetStringAsync("https://www.googleapis.com/youtube/v3/playlistItems?playlistId=" + playlistId + "&key=" + _key + "&part=contentDetails,snippet,status&maxResults=49"));
			return value.Results as List<HttpYoutubeVid>;
		}

		public async Task GetChannelAsync(string channelId)
		{
			Console.WriteLine(await _client.GetStringAsync("https://www.googleapis.com/youtube/v3/channels?id=" + channelId + "&key=" + _key + "&part=brandingSettings,contentDetails,contentOwnerDetails,snippet,statistics,status,topicDetails"));
		}

		internal async Task<string> GetVideoInfoAsync(string videoId)
		{
			if (videoId == null)
			{
				return null;
			}
			try
			{
				return await _client.GetStringAsync("https://www.youtube.com/get_video_info?html5=1&video_id=" + videoId);
			}
			catch
			{
				return null;
			}
		}

		internal async Task<Stream> GetStreamAsync(string url)
		{
			return await _client.GetStreamAsync(url);
		}

		private async Task<string> GetVideoUrlAsync(string videoId)
		{
			string value = await GetVideoInfoAsync(videoId);
			if (value == null)
			{
				throw new InvalidOperationException("Retrieving of videoinfo unsuccessful");
			}
			NameValueCollection query = HttpUtility.ParseQueryString(value);
			query.GetValues("url_encoded_fmt_stream_map");
			NameValueCollection videos = HttpUtility.ParseQueryString(query.GetValues("url_encoded_fmt_stream_map")[0]);
			string url = videos.GetValues("url")[0];
			return url ?? "";
		}

		public async Task<byte[]> GetVideoBytesAsync(string videoId)
		{
			return await GetBytesAsync(await GetVideoUrlAsync(videoId));
		}

		public async Task<Stream> GetVideoBytes(string videoId)
		{
			return await GetStreamAsync(await GetVideoUrlAsync(videoId));
		}

		public void Dispose()
		{
			if (!_disposed)
			{
				_disposed = true;
				_client.Dispose();
			}
		}
	}
}
