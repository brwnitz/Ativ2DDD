using DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Interfaces
{
    public interface INoticesRepository
    {
        IEnumerable<Notices> GetNotices();
        Notices GetById(int id);
    }
}
