using AutoMapper;
using DomainModels.Interfaces;
using ServicesModel.Interfaces;
using ServicesModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModel.Services
{
    public class NoticesService : INoticesService
    {
        private INoticesRepository _noticesRepository;

        private readonly IMapper _mapper;
        public NoticesService(INoticesRepository noticesRepository, IMapper mapper)
        {
            _noticesRepository = noticesRepository;
            _mapper = mapper;
        }

        public IEnumerable<NoticesViewModel> GetNotices()
        {
            var notices = _noticesRepository.GetNotices();
            return _mapper.Map<IEnumerable<NoticesViewModel>>(notices);
        }        
    }
}
