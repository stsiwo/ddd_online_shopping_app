using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    public class UserId
    {
        public readonly String userId;

        public UserId()
        {
            this.userId = System.Guid.NewGuid().ToString();
        }
    }
}
