using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.UserAggregate
{
    public class UserType
    {
        public readonly UserTypeEnum userType;

        public UserType()
        {
            // default is guest user
            this.userType = UserTypeEnum.Guest; 
        }

        public override string ToString()
        {
            return this.userType.ToString();
        }


    }
}
