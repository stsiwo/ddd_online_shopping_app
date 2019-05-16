using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StsOnlineShopApp.Application;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using StsOnlineShopApp.UI.DTO;

namespace StsOnlineShopApp.Infrastructure.Repository
{
    /**
     * #TASK: 
     *  1. inject DbContext per request
     *  2. integrate with Specification Pattern
     *  3. unit test
     **/
    public class ProductRepository : IProductRepository
    {
        private AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            this._context = context;
        }
        public List<Product> getAllProducts()
        {
            // 1. get Products from DbContext
            var results = this._context.Product.

            // 2. assign results to List<Product> DTO

            // 3. return it!!
        }

        public List<Product> getProducts(ISpecification<Product> specification)
        {
            throw new NotImplementedException();
        }
    }
}
