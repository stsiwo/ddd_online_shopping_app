using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class Description
    {
        public readonly String description;

        public Description(String description)
        {
            this.description = description; 
        }
    }
}
