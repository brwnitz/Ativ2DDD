using DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Interfaces
{
    public interface IUserService
    {
        User SelectByEmailAndPassword(string email, string password, string passwordcheck);
    }
}
