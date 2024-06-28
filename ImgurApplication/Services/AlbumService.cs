using ImgurAPI.Models;
using ImgurApplication.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApplication.Services
{
    public class AlbumService
    {
        public async Task<List<KeyValues>> GetAlbumsList()
        {
            AlbumsModel albumsModel = await ImgurAPI.Album.GetAlbums("pingyen");
            List<KeyValues> comboList = albumsModel.data.Select(x => new KeyValues(x.title, x.id)).ToList();
            comboList.Insert(0, new KeyValues("無", "no"));
            return comboList;
        }

        public async Task<List<KeyValues>> ViewAlbumsList()
        {
            List<KeyValues> comboList = await GetAlbumsList();
            comboList.RemoveAt(0);
            comboList.Insert(0, new KeyValues("All Images", "all"));
            comboList.Insert(0, new KeyValues("Non-album Images", "non"));
            return comboList;
        }

    }
}
