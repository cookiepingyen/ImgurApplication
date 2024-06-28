using ImgurAPI;
using ImgurAPI.Enums;
using ImgurAPI.Models;
using ImgurApplication.Enums;
using ImgurApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace ImgurApplication.Components
{
    public partial class GalleryComponent : UserControl
    {
        GalleryModel.Datum data;
        public EventHandler<GalleryModel.Datum> GalleryClicked;
        VoteService voteService = new VoteService();


        public GalleryComponent(GalleryModel.Datum data)
        {
            InitializeComponent();
            this.data = data;
            label6.Text = data.title;
            label5.Text = data.views.ToString();
            label3.Text = data.points.ToString();
            label8.Text = data.comment_count.ToString();

            (Color, Color) colors = voteService.GetVoteColors((string)data.vote);
            label1.ForeColor = colors.Item1;
            label2.ForeColor = colors.Item2;


            string link = data.images != null ? $"https://i.imgur.com/{data.images[0].id}.jpeg" : data.link;
            pictureBox1.LoadAsync(link);
            //pictureBox1.LoadAsync($"{data.link}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            VoteDTO voteDTO = new VoteDTO(data.id, data.vote?.ToString(), data.points, label.Tag.ToString());
            label3.Text = voteService.PostVote(voteDTO, CommentType.image);
            data.points = voteDTO.points;
            data.vote = voteDTO.vote;

            (Color, Color) colors = voteService.GetVoteColors(voteDTO.vote);
            label1.ForeColor = colors.Item1;
            label2.ForeColor = colors.Item2;
        }

        private void GalleryComponent_Click(object sender, EventArgs e)
        {
            GalleryClicked(this, data);
        }

    }
}
