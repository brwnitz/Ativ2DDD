using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Dislike : BaseEntity
    {
        public int UserId { get; set; }
        public int PostagemId { get; set; }
        public string DislikeDate { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
    }
}
