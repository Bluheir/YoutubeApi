using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IBrandingChannel
	{
		string Title
		{
			get;
		}

		string Description
		{
			get;
		}

		string Keywords
		{
			get;
		}

		string DefaultTab
		{
			get;
		}

		bool ModerateComments
		{
			get;
		}

		bool ShowRelatedChannels
		{
			get;
		}

		bool ShowBrowseView
		{
			get;
		}

		string FeaturedChannelsTitle
		{
			get;
		}

		IReadOnlyList<string> FeaturedChannelUrls
		{
			get;
		}

		string UnsubscribedTrailer
		{
			get;
		}

		string ProfileColour
		{
			get;
		}

		string DefaultLanguage
		{
			get;
		}

		string Country
		{
			get;
		}

		IImageObject BannerImages
		{
			get;
		}

		IReadOnlyList<IYoutubeHint> Hints
		{
			get;
		}

		Task<IReadOnlyList<IYoutubeChannel>> GetFeaturedChannelsAsync();

		Task<IYoutubeVideo> GetUnsubscribedVideoAsync();
	}
}
