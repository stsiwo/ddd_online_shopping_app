using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class Comment
    {
        public readonly String comment;

        public Comment(String comment)
        {
            this.comment = comment; 
        }
    }
}
