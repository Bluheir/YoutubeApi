namespace YoutubeApiTest.Models
{
	public interface IContentDetails
	{
		string Duration
		{
			get;
		}

		string Dimension
		{
			get;
		}

		string Definition
		{
			get;
		}

		string Caption
		{
			get;
		}

		bool LicensedContent
		{
			get;
		}

		string Projection
		{
			get;
		}
	}
}
