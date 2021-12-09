using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Models
{
    public class Post : BaseEntity
    {
        public int UserId { get; set; }
        public string PostDate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string Commentaries { get; set; }
        public string Description { get; set; }

        public User User { get; set; }

    }
}
