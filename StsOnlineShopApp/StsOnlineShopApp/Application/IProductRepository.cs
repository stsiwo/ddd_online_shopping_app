using StsOnlineShopApp.UI.DTO;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using System.Collections.Generic;

namespace StsOnlineShopApp.Application
{
    public interface IProductRepository
    {
        List<Product> getProducts(ISpecification<Product> specification);

        List<Product> getAllProducts();
    }
}
