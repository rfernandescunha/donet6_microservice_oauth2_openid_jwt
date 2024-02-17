using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;
using System.Net.Http.Headers;

namespace GeekShopping.Web.Services
{
    public class ProductApiServices : IProductApiServices
    {
        private readonly HttpClient _httpClient;
        public const string basePath = "api/v1/product";

        public ProductApiServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ProductModel> Create(ProductModel model, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.PostAsync(basePath, model);

            return response;
        }

        public async Task<ProductModel> Update(ProductModel model, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.PutAsync(basePath, model);

            return response;
        }

        public async Task<bool> Delete(long id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.DeleteAsync($"{basePath} / {id}");

            return await response.ReadContentAs<bool>();
        }

        public async Task<IEnumerable<ProductModel>> FindAll()
        {
            var response = await _httpClient.GetAsync(basePath);

            return await response.ReadContentAs<IEnumerable<ProductModel>>();
        }

        public async Task<IEnumerable<ProductModel>> FindAll(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync(basePath);

            return await response.ReadContentAs<IEnumerable<ProductModel>>();
        }

        public async Task<ProductModel> FindById(long id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync($"{basePath}/{id}");

            return await response.ReadContentAs<ProductModel>();
        }


    }
}
