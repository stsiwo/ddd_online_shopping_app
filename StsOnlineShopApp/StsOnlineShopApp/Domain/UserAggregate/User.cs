using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    // Aggregate Root
    /**
     * Aggregate Root Rules
     *  1. Root is the only one who can communicate with outside
     *  2. Id must be global identity
     *  3. outside can have the reference of the Root
     *  4. can have Repository
     *  5. delete operation must delete the whole Aggregate including its associated Entities and VOs
     *  6. when the Aggregate is modified, every objects in this Aggregate, it must keep invariants about this Aggregate.
     **/
    public class User
    {
        public UserId UserId { get; set; } 
        public UserType UserType { get; set; }

        private Cart Cart; 
        public CreationDate CreationDate { get; set; }

        public User()
        {
            this.UserId = new UserId();
            this.UserType = new UserType();
            this.CreationDate = new CreationDate();
            this.Cart = new Cart();
        }

        public void AddProductToCart(ProductId productId)
        {
            this.Cart.AddProduct(productId);
        }

        public void RemoveProductFromCart(ProductId productId)
        {
            this.Cart.RemoveProudct(productId);
        }

        public int GetSizeOfCart()
        {
            return this.Cart.GetSize();
        }

        public List<ProductId> GetProductsInCart()
        {
            return this.Cart.ProductList;
        }
    }
}
