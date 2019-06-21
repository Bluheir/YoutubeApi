using System.IO;
using System.Threading.Tasks;

namespace YoutubeApiTests.Methods
{
	public static class FileMethods
	{
		public static async Task WriteBytesAsync(string filePath, byte[] data)
		{
			using (FileStream sourceStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.None, data.Length, useAsync: true))
			{
				await sourceStream.WriteAsync(data, 0, data.Length);
			}
		}
	}
}
