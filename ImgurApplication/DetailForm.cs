using ImgurAPI;
using ImgurAPI.Enums;
using ImgurAPI.Models;
using ImgurApplication.Components;
using ImgurApplication.Enums;
using ImgurApplication.Models;
using ImgurApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ImgurAPI.GalleryModel;
using static ImgurAPI.Models.CommentResModel;
using Label = System.Windows.Forms.Label;

namespace ImgurApplication
{
    public partial class DetailForm : Form
    {
        CommentsComponent commentsComponentSelected;
        CommentType commentType = CommentType.image;
        Datum data;
        VoteService voteService = new VoteService();
        public DetailForm(Datum data)
        {
            InitializeComponent();
            this.data = data;
        }

        private async void DetailForm_Load(object sender, EventArgs e)
        {
            this.InitGallery();

        }

        private void InitGallery()
        {
            title.Text = data.title;
            labelViews.Text = data.views.ToString();
            commentID.Text = data.id;

            SetVoteColor();

            CreateArticleContent(data.images);

            CreateGalleryComments(data.id);
        }

        private async void CreateGalleryComments(string galleryID)
        {
            CommentResModel comments = await CommentService.GetImageComments(galleryID);
            foreach (Comments data in comments.data)
            {
                CommentsComponent commentsComponent = new CommentsComponent(data, replyBtnClick);
                flowLayoutPanel2.Controls.Add(commentsComponent);
            }

        }

        private void CreateArticleContent(GalleryModel.Image[] images)
        {
            foreach (GalleryModel.Image image in images)
            {
                string link = (image.link.Contains("mp4") || image.link.Contains("wmv")) ?
                    $"https://i.imgur.com/{image.id}.jpeg"
                    : image.link;

                PictureBox pictureBox = new PictureBox();
                pictureBox.LoadAsync(link);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = flowLayoutPanel1.Width;
                pictureBox.Height = 200;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }

        }

        private void replyBtnClick(object sender, string e)
        {
            commentID.Text = e;
            commentType = CommentType.comment;
            commentsComponentSelected = (CommentsComponent)sender;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            commentID.Text = data.id;
            commentType = CommentType.image;
        }

        private void SetVoteColor()
        {
            labelPoint.Text = data.points.ToString();

            (Color, Color) colors = voteService.GetVoteColors((string)data.vote);
            labelUp.ForeColor = colors.Item1;
            labelDown.ForeColor = colors.Item2;

        }

        private void vote_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            VoteDTO voteDTO = new VoteDTO(data.id, data.vote?.ToString(), data.points, label.Tag.ToString());
            labelPoint.Text = voteService.PostVote(voteDTO, CommentType.image);
            data.points = voteDTO.points;
            data.vote = voteDTO.vote;

            (Color, Color) colors = voteService.GetVoteColors(voteDTO.vote);
            labelUp.ForeColor = colors.Item1;
            labelDown.ForeColor = colors.Item2;
        }

        private void postBtnClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(commentBox.Text))
            {
                MessageBox.Show("輸入框要有內容");
                return;
            }
            PostComment();
            ClearCommentInput();
        }

        private void ClearCommentInput()
        {
            commentID.Text = "";
            commentBox.Text = "";
        }

        private async void PostComment()
        {
            CommentRequestModel commentRequestModel = new CommentRequestModel(data.id, commentBox.Text);
            if (commentType == CommentType.comment)
            {
                CommentsComponent commentsComponent = await CommentService.CreateComment(CommentType.comment, commentRequestModel, replyBtnClick);
                commentsComponentSelected.InsertNewComment(commentsComponent);
                commentsComponentSelected.OpenSubFlowoutpanel();
            }
            else if (commentType == CommentType.image)
            {
                CommentsComponent commentsComponent = await CommentService.CreateComment(CommentType.image, commentRequestModel, replyBtnClick);
                flowLayoutPanel2.Controls.Add(commentsComponent);
            }
        }
    }
}