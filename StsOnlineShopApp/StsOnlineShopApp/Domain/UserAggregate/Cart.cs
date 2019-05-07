using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    // Entity
    public class Cart
    {
        public CartId CartId { get; set; }
        // should be ProductId instead of String?
        // #REVIEW
        public List<String> ProductList { get; set; }

        public Cart()
        {
            this.CartId = new CartId();
        }

        public void AddProduct(String productId)
        {
            this.ProductList.Add(productId);
        }

        public void RemoveProudct(String productId)
        {
            this.ProductList.Remove(productId);
        }
    }
}
