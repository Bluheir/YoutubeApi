using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IYoutubePlaylist : IYoutubeEntity, IEnumerable<IYoutubeVideo>, IEnumerable
	{
		string Id
		{
			get;
		}

		IVideoSnippet Snippet
		{
			get;
		}

		IVideoStatus PrivacyStatus
		{
			get;
		}

		IContentDetails ContentDetails
		{
			get;
		}

		Task<IReadOnlyList<IYoutubeVideo>> GetVideosAsync();
	}
}
