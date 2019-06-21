using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IYoutubeChannel : IYoutubeEntity
	{
		IVideoSnippet Snippet
		{
			get;
		}

		string Id
		{
			get;
		}

		IChannelContentDetails ContentDetails
		{
			get;
		}

		IChannelStatistics Statistics
		{
			get;
		}

		ITopicDetails TopicDetails
		{
			get;
		}

		IChannelStatus Status
		{
			get;
		}

		IBrandingChannel BrandingSettings
		{
			get;
		}

		IContentOwnerDetails OwnerDetails
		{
			get;
		}

		Task<IYoutubePlaylist> GetUploadedVideosAsync();
	}
}
