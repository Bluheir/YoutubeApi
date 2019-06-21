namespace YoutubeApiTest.Models
{
	public interface IChannelStatistics
	{
		ulong ViewCount
		{
			get;
		}

		ulong CommentCount
		{
			get;
		}

		ulong SubscriberCount
		{
			get;
		}

		bool HiddenSubscriberCount
		{
			get;
		}

		ulong VideoCount
		{
			get;
		}
	}
}
