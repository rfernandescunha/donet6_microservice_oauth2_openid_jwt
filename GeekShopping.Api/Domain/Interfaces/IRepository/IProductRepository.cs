using GeekShopping.Api.Domain.Entities;

namespace GeekShopping.Api.Domain.Interfaces.IRepository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> FindAll();
        Task<Product> FindById(long Id);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<bool> Delete(long Id);
    }
}
