using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.UI.DTO
{
    public class SubImage : DTO
    {
        public String Id { get; private set; }
        public String Url { get; private set; }
        public int ProductId  { get; private set; }
    }
}
