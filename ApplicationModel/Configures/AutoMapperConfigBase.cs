using Microsoft.Extensions.DependencyInjection;
using ServicesModel.AutoMapper;
using System.Reflection;

namespace ApplicationModel.Configures
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
            => services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfile)));
    }
}