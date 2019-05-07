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
            // need some logic to distinguish the user is login or not
            // #REFACTOR 
            this.userType = UserTypeEnum.Guest;
        } 
            
    }
}
