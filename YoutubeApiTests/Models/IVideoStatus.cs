namespace YoutubeApiTest.Models
{
	public interface IVideoStatus
	{
		string UploadStatus
		{
			get;
		}

		string PrivacyStatus
		{
			get;
		}

		string License
		{
			get;
		}

		bool Embeddable
		{
			get;
		}

		bool PublicStatsViewable
		{
			get;
		}
	}
}
