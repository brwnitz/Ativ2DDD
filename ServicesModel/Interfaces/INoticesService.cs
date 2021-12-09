using ServicesModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModel.Interfaces
{
    public interface INoticesService
    {
        IEnumerable<NoticesViewModel> GetNotices();
    }
}
