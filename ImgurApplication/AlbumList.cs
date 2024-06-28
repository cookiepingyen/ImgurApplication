using ImgurAPI;
using ImgurAPI.Models;
using ImgurApplication.Components;
using ImgurApplication.Models;
using ImgurApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImgurAPI.Models.AlbumImagesModel;

namespace ImgurApplication
{
    public partial class AlbumList : Form
    {
        public AlbumList()
        {
            InitializeComponent();
            InitPage();
        }


        private async Task InitPage()
        {
            AlbumService albumService = new AlbumService();
            List<KeyValues> albumlist = await albumService.ViewAlbumsList();
            albumComboBox.SetCombox(albumlist, "ValueString");
        }

        private async void albumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageFlowLayout.Controls.Clear();
            if (!(albumComboBox.SelectedValue is string))
            {
                return;
            }
            if (albumComboBox.SelectedValue == "all")
            {
                AlbumImagesModel albumImagesModel = await ImgurAPI.Image.GetAccountImages();
                foreach (Datum data in albumImagesModel.data)
                {
                    AlbumImagesComponent albumImagesComponent = new AlbumImagesComponent(data);
                    albumImagesComponent.Margin = new Padding(0, 5, 0, 5);
                    imageFlowLayout.Controls.Add(albumImagesComponent);
                }

            }
            else if (albumComboBox.SelectedValue == "non")
            {

            }
            else
            {
                string albumId = albumComboBox.SelectedValue.ToString();
                AlbumImagesModel albumImagesModel = await Album.GetAlbumImages(albumId);
                foreach (Datum data in albumImagesModel.data)
                {
                    AlbumImagesComponent albumImagesComponent = new AlbumImagesComponent(data);
                    albumImagesComponent.Margin = new Padding(0, 5, 0, 5);
                    imageFlowLayout.Controls.Add(albumImagesComponent);
                }

            }
        }
    }
}
