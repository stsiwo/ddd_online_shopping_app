using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class Author
    {
        public readonly String author;

        public Author(String author)
        {
            this.author = author; 
        }
    }
}
