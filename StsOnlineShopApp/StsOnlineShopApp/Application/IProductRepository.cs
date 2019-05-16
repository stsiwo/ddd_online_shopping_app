using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StsOnlineShopApp.Infrastructure.Specification.Core;

namespace StsOnlineShopApp.Application
{
    public interface IProductRepository
    {
        getProducts(ISpecification specification);
    }
}
