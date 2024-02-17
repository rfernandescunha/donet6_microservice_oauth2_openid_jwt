using GeekShopping.Web.Services;
using GeekShopping.Web.Services.IServices;

namespace GeekShopping.Web.Clients
{
    public static class InjectionApiClientService
    {
        public static void AddApiClientServiceConfig(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //serviceCollection.AddHttpClient<IProductServices, ProductServices>().ConfigureHttpClient((sProvider, httpCliente) =>
            //{
            //    var url = sProvider.GetRequiredService<IOptions<UrlConfigs>>().Value.ProductApi;

            //    httpCliente.BaseAddress = url;
            //    httpCliente.Timeout = TimeSpan.FromMinutes(5);

            //});

            var url = configuration.GetSection("ServicesUrl").GetSection("ProductApi").Value;

            serviceCollection.AddHttpClient<IProductApiServices, ProductApiServices>(c => c.BaseAddress = new Uri(url));

        }
    }
}