using Newtonsoft.Json;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	public sealed class HttpVidStatistics : IVideoStatistics
	{
		[JsonProperty("viewCount")]
		public string ViewCount
		{
			get;
			private set;
		}

		[JsonProperty("likeCount")]
		public string LikeCount
		{
			get;
			private set;
		}

		[JsonProperty("dislikeCount")]
		public string DislikeCount
		{
			get;
			private set;
		}

		[JsonProperty("favoriteCount")]
		public string FavoriteCount
		{
			get;
			private set;
		}

		[JsonProperty("commentCount")]
		public string CommentCount
		{
			get;
			private set;
		}
	}
}
