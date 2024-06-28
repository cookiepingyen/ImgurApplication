using ImgurAPI;
using ImgurApplication.Enums;
using ImgurApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImgurAPI.Models.CommentResModel;

namespace ImgurApplication.Components
{
    public partial class CommentsComponent : UserControl
    {
        private int childrenNum;
        private bool childCommentOpen = false;
        public event EventHandler<string> replyBtnClick;
        private Comments comments = null;
        VoteService voteService = new VoteService();
        public CommentsComponent(Comments comment, EventHandler<string> handler)
        {
            InitializeComponent();
            this.comments = comment;
            this.replyBtnClick = handler;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Margin = new Padding(30, 0, 0, 30);
            titleLab.Text = comment.comment;
            authorLab.Text = comment.author;
            pointsLab.Text = comment.points.ToString();
            Height = 120;
            (Color, Color) colors = voteService.GetVoteColors(comment.vote?.ToString());
            upLab.ForeColor = colors.Item1;
            downLab.ForeColor = colors.Item2;
            reply.Tag = comment.id;
            childrenNum = comment.children.Length;
            replies.Text = childrenNum == 0 ? "" : $"+ {childrenNum.ToString()} replies";

            foreach (Comments subComment in comment.children)
            {
                InsertNewComment(new CommentsComponent(subComment, handler));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (childCommentOpen)
            {
                childCommentOpen = !childCommentOpen;
                Height = 120;
                flowLayoutPanel1.Height = 0;
            }
            else
            {
                childCommentOpen = !childCommentOpen;
                Height += childrenNum * 150;
                flowLayoutPanel1.Height += childrenNum * 150;
            }
        }

        private void reply_Click(object sender, EventArgs e)
        {
            replyBtnClick.Invoke(this, this.comments.id.ToString());
        }

        public void InsertNewComment(CommentsComponent newCommentComponent)
        {
            flowLayoutPanel1.Controls.Add(newCommentComponent);
        }

        public void OpenSubFlowoutpanel()
        {
            childrenNum++;
            childCommentOpen = true;
            replies.Text = replies.Text == "" ? "+ 1 replies" : $"{(childrenNum).ToString()} replies";
            Height += 150;
            flowLayoutPanel1.Height += 150;
        }

        private void CommentVote(object sender, EventArgs e)
        {
            Label label = (Label)sender;

            VoteDTO voteDTO = new VoteDTO(comments.id.ToString(), comments.vote?.ToString(), comments.points, label.Tag.ToString());
            pointsLab.Text = voteService.PostVote(voteDTO, CommentType.comment);
            comments.points = voteDTO.points;
            comments.vote = voteDTO.vote;

            (Color, Color) colors = voteService.GetVoteColors(voteDTO.vote);
            upLab.ForeColor = colors.Item1;
            downLab.ForeColor = colors.Item2;

        }
    }
}
