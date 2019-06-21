namespace YoutubeApiTest.Models
{
	public interface IChannelStatus
	{
		string PrivacyStatus
		{
			get;
		}

		bool IsLinked
		{
			get;
		}

		string LongUploadStatus
		{
			get;
		}
	}
}
