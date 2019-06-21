namespace YoutubeApiTest.Models
{
	public interface IVideoThumbnails
	{
		IVideoThumbnail Default
		{
			get;
		}

		IVideoThumbnail Medium
		{
			get;
		}

		IVideoThumbnail High
		{
			get;
		}

		IVideoThumbnail Standard
		{
			get;
		}

		IVideoThumbnail MaxRes
		{
			get;
		}
	}
}
