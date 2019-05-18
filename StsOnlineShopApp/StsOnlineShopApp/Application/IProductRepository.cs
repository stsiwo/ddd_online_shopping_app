using StsOnlineShopApp.UI.DTO;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;


namespace StsOnlineShopApp.Application
{
    public interface IProductRepository
    {
        List<Product> getProducts(Dictionary<string, StringValues> qs);

        List<Product> getAllProducts();
    }
}
