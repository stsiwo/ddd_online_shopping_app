using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.DataEntity
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string Id, string Name, decimal Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }


        
    }
}
