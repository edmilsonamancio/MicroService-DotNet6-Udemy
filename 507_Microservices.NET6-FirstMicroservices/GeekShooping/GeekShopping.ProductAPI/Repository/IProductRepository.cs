using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public class IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();
        Task<ProductVO> FindById(longId);
        Task<ProductVO> Create(ProductVO productVO);
        Task<ProductVO> Update(ProductVO productVO);
        Task<bool> Delete(long id);
    }
}
