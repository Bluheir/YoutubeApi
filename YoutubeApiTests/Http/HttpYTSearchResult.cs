using Newtonsoft.Json;
using System.Collections.Generic;
using YoutubeApiTest.Models;

namespace YoutubeApiTest.Http
{
	internal sealed class HttpYTSearchResult<T> : IYoutubeEntity where T : IYoutubeEntity
	{
		[JsonProperty("items")]
		private List<T> _results;

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

		public IReadOnlyList<T> Results => _results;

		internal HttpYTSearchResult()
		{
		}
	}
}
