using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Commentary : BaseEntity
    {
        public string CommentDesc { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string CommentDate { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
