using System;
using System.Threading.Tasks;
using YoutubeApiTest.Http;

namespace YoutubeApiTests
{
	class Program
	{
		private static void Main()
		=> new Program().MainAsync().GetAwaiter().GetResult();
		
		private async Task MainAsync()
		{
			using (YoutubeClient client = new YoutubeClient("AIzaSyAXs5m7OJAmNNQ43WZCpjzyaIwrhgTl1EQ"))
			{
				Console.WriteLine("You fucking bitch, what is the id of the video you would like to get?");
				var vid = await client.GetVideoAsync(Console.ReadLine());
				await vid.DownloadVideoAsync(@"C:\Users\User\Desktop\SexyPornVid.txt");
			}
		}
	}
}