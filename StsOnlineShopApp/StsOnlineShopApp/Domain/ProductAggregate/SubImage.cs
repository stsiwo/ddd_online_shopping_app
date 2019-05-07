using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class SubImage
    {
        public readonly Image subImage;

        public SubImage(Image subImage)
        {
            this.subImage = subImage; 
        }
    }
}
