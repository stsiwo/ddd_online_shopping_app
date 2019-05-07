using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class CreationDate
    {
        public readonly DateTime creationDate;

        public CreationDate()
        {
            this.creationDate = DateTime.Now;
        }
        public override string ToString()
        {
            return creationDate.ToString("MM/dd/yyyy");
        }
    }
}
