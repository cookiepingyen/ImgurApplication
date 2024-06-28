using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApplication
{
    public partial class AlbumImagesComponent : UserControl
    {
        public AlbumImagesComponent(AlbumImagesModel.Datum data)
        {
            InitializeComponent();
            imageBox.LoadAsync(data.link);
            titleLabel.Text = data.title;

            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
