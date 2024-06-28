using ImgurAPI.Enums;
using ImgurAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImgurAPI.GalleryModel;
using static ImgurAPI.Models.GalleryImage;
using System.Drawing;
using ImgurApplication.Models;
using System.Collections;
using ImgurApplication.Enums;

namespace ImgurApplication
{

    internal class VoteService
    {
        public string PostVote(VoteDTO data, CommentType commentType)
        {
            if (data.vote == data.tag)
            {
                //收回投票

                if (commentType == CommentType.image)
                {
                    Vote.VoteImag(data.id, VoteTypes.veto);
                }
                else
                {
                    Comment.CommentVote(data.id, VoteTypes.veto);
                }


                data.points = (data.tag == "up" ? data.points - 1 : data.points + 1);
                data.vote = "veto";
                return data.points.ToString();
            }
            else
            {

                //投票
                VoteTypes voteType = (VoteTypes)Enum.Parse(typeof(VoteTypes), data.tag, true);
                if (commentType == CommentType.image)
                {
                    Vote.VoteImag(data.id, voteType);
                }
                else
                {
                    Comment.CommentVote(data.id, voteType);
                }

                if (data.vote == null || data.vote == "veto")
                {
                    data.points = data.tag == "up" ? data.points + 1 : data.points - 1;
                }
                else
                {
                    data.points = data.tag == "up" ? data.points + 2 : data.points - 2;
                }

                data.vote = data.tag;
                return data.points.ToString();
            }
        }

        public string GetVoteNumber(VoteDTO data)
        {
            switch (data.vote)
            {
                case "up":
                    data.points += 1;
                    break;
                case "down":
                    data.points -= 1;
                    break;
            }
            return data.points.ToString();
        }

        public (Color, Color) GetVoteColors(string vote)
        {
            if (vote == null || vote == "veto")
            {
                return (Color.Black, Color.Black);
            }
            else if (vote == "up")
            {
                return (Color.Green, Color.Black);
            }
            else if (vote == "down")
            {
                return (Color.Black, Color.Red);
            }
            else
            {
                return (Color.Black, Color.Black);
            }
        }
    }
}
