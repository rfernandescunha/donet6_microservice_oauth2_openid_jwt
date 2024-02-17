using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductApiServices
    {
        Task<IEnumerable<ProductModel>> FindAll();
        Task<IEnumerable<ProductModel>> FindAll(string token);
        Task<ProductModel> FindById(long id, string token);
        Task<ProductModel> Create(ProductModel model, string token);
        Task<ProductModel> Update(ProductModel model, string token);
        Task<bool> Delete(long id, string token);
    }
}
