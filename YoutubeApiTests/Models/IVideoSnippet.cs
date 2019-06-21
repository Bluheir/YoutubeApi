using System.Collections.Generic;

namespace YoutubeApiTest.Models
{
	public interface IVideoSnippet
	{
		string PublishedAt
		{
			get;
		}

		string ChannelId
		{
			get;
		}

		string Title
		{
			get;
		}

		string ChannelTitle
		{
			get;
		}

		string Description
		{
			get;
		}

		string LiveBroadcastContent
		{
			get;
		}

		IVideoThumbnails Thumbnails
		{
			get;
		}

		string CategoryId
		{
			get;
		}

		IReadOnlyList<string> Tags
		{
			get;
		}
	}
}
