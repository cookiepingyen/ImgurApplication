using ImgurAPI;
using ImgurAPI.Enums;
using ImgurApplication.Components;
using ImgurApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 分頁;
using static ImgurAPI.GalleryModel;

namespace ImgurApplication
{
    public partial class Form1 : Form
    {
        GalleryModel galleryModel = null;
        Pagination pagination = new Pagination();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            List<KeyValues> sortlist = new List<KeyValues>();
            sortlist.Add(new KeyValues("time", 1));
            sortlist.Add(new KeyValues("viral", 2));
            sortlist.Add(new KeyValues("top", 3));
            comboBox1.SetCombox(sortlist);

            List<KeyValues> periodlist = new List<KeyValues>();
            periodlist.Add(new KeyValues("all", 4));
            periodlist.Add(new KeyValues("day", 1));
            periodlist.Add(new KeyValues("month", 2));
            periodlist.Add(new KeyValues("year", 3));
            comboBox2.SetCombox(periodlist);

            flowLayoutPanel2.Controls.Add(pagination);
            pagination.ChangePage += Pagination_ChangePage;
        }

        private void Pagination_ChangePage(object sender, int e)
        {
            GenerageImage(galleryModel, e);
            Console.WriteLine(e);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string q = textBox1.Text;
            GallerySortType sort = (GallerySortType)comboBox1.SelectedValue;
            GalleryWindowType window = (GalleryWindowType)comboBox2.SelectedValue;

            galleryModel = await Gallery.SearchGalleryByCondition(q, 1, sort, window);
            pagination.TotalData = galleryModel.data.Count();

            GenerageImage(galleryModel, 1);
        }

        private void GenerageImage(GalleryModel galleryModel, int page)
        {
            foreach (GalleryComponent component in flowLayoutPanel1.Controls)
            {
                component.Dispose();
            }
            flowLayoutPanel1.Controls.Clear();
            GC.Collect();

            foreach (var data in galleryModel.data.Skip((page - 1) * 6).Take(6)) // 60
            {
                GalleryComponent galleryComponent = new GalleryComponent(data);
                galleryComponent.Margin = new Padding(0, 15, 0, 15);
                galleryComponent.GalleryClicked += ImageClick;
                flowLayoutPanel1.Controls.Add(galleryComponent);
            }
        }

        private void ImageClick(object sender, Datum data)
        {
            DetailForm detailForm = new DetailForm(data);
            detailForm.ShowDialog();
        }

        private void 上傳相片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageUpload imageUpload = new ImageUpload();
            imageUpload.ShowDialog();
        }

        private void 相簿列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlbumList albumList = new AlbumList();
            albumList.ShowDialog();
        }
    }
}
