using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    // Aggregate Root
    public class User
    {
        public UserId UserId { get; set; } 
        public UserType UserType { get; set; } 
        public Cart Cart { get; private set; }
        public CreationDate CreationDate { get; set; }

        public User()
        {
            this.UserId = new UserId();
            this.UserType = new UserType();
            this.CreationDate = new CreationDate();
            this.Cart = new Cart();
        }

        public void AddProductToCart(String productId)
        {
            this.Cart.AddProduct(productId);
        }

        public void RemoveProductFromCart(String productId)
        {
            this.Cart.RemoveProudct(productId);
        }
    }
}
