using System;
using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IContentOwnerDetails
	{
		string ContentOwner
		{
			get;
		}

		string TimeLinked
		{
			get;
		}

		Task<IYoutubeChannel> GetOwnerAsync();

		DateTime GetTimeLinked();
	}
}
