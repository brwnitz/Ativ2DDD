using DataModel.Context;
using DomainModels.Interfaces;
using DomainModels.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repository
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(MyContext context) : base(context)
        {
        }

        public Post GetById(int id)
        {
            var obj = CurrentSet
                    .Include(x => x.User)
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

            return obj;
        }

        public IEnumerable<Post> GetPost()
        {
            var obj = CurrentSet
                .Include(x => x.User)
                .ToList();

            return obj;
        }       
    }
}
