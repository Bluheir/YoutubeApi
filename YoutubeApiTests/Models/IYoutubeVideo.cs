using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IYoutubeVideo : IYoutubeEntity
	{
		string Id
		{
			get;
		}

		IVideoSnippet Snippet
		{
			get;
		}

		IVideoStatistics Statistics
		{
			get;
		}

		IContentDetails ContentDetails
		{
			get;
		}

		IVideoStatus PrivacyStatus
		{
			get;
		}

		Task<bool> DownloadThumnailAsync(string filePath, ThumbnailType thumbnailType = ThumbnailType.MaxRes);

		Task DownloadVideoAsync(string filePath);

		Task<byte[]> GetVideoBytesAsync();
	}
}
