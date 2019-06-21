namespace YoutubeApiTest.Models
{
	public interface IVideoThumbnail
	{
		string Url
		{
			get;
		}

		uint Width
		{
			get;
		}

		uint Height
		{
			get;
		}
	}
}
