using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurApplication.Models
{
    public class VoteDTO
    {
        public string id { get; set; }
        public string vote { get; set; }
        public int points { get; set; }
        public string tag { get; set; }

        public VoteDTO(string id, string vote, int points, string tag = null)
        {
            this.id = id;
            this.vote = vote;
            this.points = points;
            this.tag = tag;
        }
    }
}
