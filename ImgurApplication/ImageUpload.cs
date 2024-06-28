using ImgurAPI.Models;
using ImgurApplication.Models;
using ImgurApplication.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgurApplication
{
    public partial class ImageUpload : Form
    {
        string result = "";
        string filePath = "";
        PictureBox pictureBox = null;

        public ImageUpload()
        {
            InitializeComponent();
            InitPage();

        }

        private async Task InitPage()
        {
            resetPictureBox();
            AlbumService albumService = new AlbumService();
            List<KeyValues> albumlist = await albumService.GetAlbumsList();
            albumComboBox.SetCombox(albumlist, "ValueString");
        }



        private void uploadImage(object sender, EventArgs e)
        {
            pictureBox = (PictureBox)sender;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF;";

            result = openFileDialog.ShowDialog().ToString();
            if (result == "OK")
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox.Tag = openFileDialog.FileName;
                filePath = openFileDialog.FileName;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                Console.WriteLine(openFileDialog.FileName);
                Console.WriteLine(pictureBox.Tag);
            }
        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            if (albumCheck.Checked && String.IsNullOrEmpty(albumBox.Text))
            {
                MessageBox.Show("請輸入相簿名稱");
                return;
            }


            ImgurAPI.ImageUpload imageUpload = await ImgurAPI.Image.UploadImage(filePath, titleBox.Text, titleBox.Text, nameLab.Text, desBox.Text);
            await ImgurAPI.Image.ShareImage(imageUpload.data.id, titleBox.Text);
            resetPictureBox();

            ImgurAPI.Models.ImageModel imageModel = await ImgurAPI.Image.GetImage(imageUpload.data.id);


            string imageModelToString = JsonConvert.SerializeObject(imageModel.data);
            ImgurAPI.GalleryModel.Image datumImage = JsonConvert.DeserializeObject<ImgurAPI.GalleryModel.Image>(imageModelToString);

            ImgurAPI.GalleryModel.Datum datum = new ImgurAPI.GalleryModel.Datum();
            datum.images = new ImgurAPI.GalleryModel.Image[] { datumImage };
            datum.description = desBox.Text;
            datum.title = titleBox.Text;
            datum.id = imageUpload.data.id;

            if (albumCheck.Checked)
            {
                ImgurAPI.Album.PostAlbum(albumBox.Text, imageUpload.data.id);
            }
            else if (albumComboBox.SelectedValue.ToString() != "no")
            {
                ImgurAPI.Album.AddPostToAlbum((string)albumComboBox.SelectedValue, imageUpload.data.id);
            }



            DetailForm detailForm = new DetailForm(datum);
            detailForm.ShowDialog();


        }

        private void resetPictureBox()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\C#基礎專案\\記帳\\upload.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void albumCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (albumCheck.Checked)
            {
                albumBox.Enabled = true;
            }
            else
            {
                albumBox.Enabled = false;
            }
        }
    }
}
