namespace YoutubeApiTest.Models
{
	public interface IVideoStatistics
	{
		string ViewCount
		{
			get;
		}

		string LikeCount
		{
			get;
		}

		string DislikeCount
		{
			get;
		}

		string FavoriteCount
		{
			get;
		}

		string CommentCount
		{
			get;
		}
	}
}
