using AutoMapper;
using DomainModels.Models;
using ServicesModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModel.AutoMapper
{
    public class NoticesProfiles : Profile
    {
        public NoticesProfiles()
        {
            CreateMap<Notices, NoticesViewModel>().ReverseMap();
        }
    }
}
