using DataModel.Repository;
using DomainModels.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ServicesModel.Interfaces;
using ServicesModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutModel.InjectionConfigure
{
    public static class Injector
    {
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {

            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IPostRepository), typeof(PostRepository));
            services.AddScoped(typeof(IPostService), typeof(PostService));
            services.AddScoped(typeof(INoticesRepository), typeof(NoticesRepository));
            services.AddScoped(typeof(INoticesService), typeof(NoticesService));

        }
    }
}
