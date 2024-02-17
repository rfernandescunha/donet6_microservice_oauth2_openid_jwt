

using GeekShopping.Api.Domain.Interfaces.IServices;
using GeekShopping.Api.Domain.Services;

namespace GeekShopping.Api.Infra.Ioc
{
    public static class InjectionService
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductServices, ProductServices>();

        }
    }
}