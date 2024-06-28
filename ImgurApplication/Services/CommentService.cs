using ImgurAPI.Models;
using ImgurAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImgurApplication.Components;
using ImgurApplication.Enums;

namespace ImgurApplication
{
    public class CommentService
    {
        public static async Task<CommentsComponent> CreateComment(CommentType commenType, CommentRequestModel commentRequestModel, EventHandler<string> replyBtnHandler)
        {
            PostResModel postResModel = (commenType == CommentType.comment) ?
                await Comment.CommentInComment(commentRequestModel) :
                await Comment.CreateComment(commentRequestModel);

            dynamic postResData = postResModel.data;

            SingleCommentResModel singleComment = await Comment.GetSingleComment(postResData.id.ToString());
            CommentsComponent commentsComponent = new CommentsComponent(singleComment.data, replyBtnHandler);
            return commentsComponent;
        }

        public static async Task<CommentResModel> GetImageComments(string imageId)
        {
            return await Comment.GetImageComments(imageId);
        }
    }
}
