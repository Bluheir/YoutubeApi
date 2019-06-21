using System.Threading.Tasks;

namespace YoutubeApiTest.Models
{
	public interface IRelatedPlaylists
	{
		string LikesPlaylist
		{
			get;
		}

		string FavouritesPlaylist
		{
			get;
		}

		string UploadsPlaylist
		{
			get;
		}

		Task<IYoutubePlaylist> GetLikesPlaylistAsync();

		Task<IYoutubePlaylist> GetFavouritesPlaylistAsync();

		Task<IYoutubePlaylist> GetUploadsPlaylistAsync();
	}
}
