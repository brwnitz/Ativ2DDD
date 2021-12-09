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
    public class NoticesRepository : BaseRepository<Notices>, INoticesRepository
    {
        public NoticesRepository(MyContext context) : base(context)
        {
        }

        public Notices GetById(int id)
        {
            var obj = CurrentSet
                    .Include(x => x.Type)
                    .Where(x => x.Id == id)
                    .FirstOrDefault();

            return obj;
        }

        public IEnumerable<Notices> GetNotices()
        {
            var obj = CurrentSet
                .Include(x => x.Type)
                .ToList();

            return obj;
        }          
    }
}
