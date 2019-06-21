using System.Collections.Generic;

namespace YoutubeApiTest.Models
{
	public interface ITopicDetails
	{
		IReadOnlyList<string> TopicCategories
		{
			get;
		}
	}
}
