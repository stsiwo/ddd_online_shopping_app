using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    // Entity
    /**
     * Entity Rules
     *  1. Entity can't communicate with outside (only visible by the Aggregate Root)
     *  2. Entity must have local identity (does not have to be global identity)
     *  3. outside can't have reference of the Entity (always go through the Aggregate)
     *  4. can't have Repository
     *  5. Entity can have a reference of another Aggregate Root
     **/
    public class Cart
    {
        public CartId CartId { get; set; } 
        // which List implementation should I use?
        // #REVIEW
        public List<ProductId> ProductList { get; set; }

        public Cart()
        {
            this.CartId = new CartId();
            this.ProductList = new List<ProductId>();
        }

        public void AddProduct(ProductId productId)
        {
            this.ProductList.Add(productId);
        }

        public void RemoveProudct(ProductId productId)
        {
            this.ProductList.Remove(productId);
        }

        public int GetSize()
        {
            return this.ProductList.Count();
        }
    }
}
