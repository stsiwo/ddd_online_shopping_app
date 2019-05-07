using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class MainImage
    {
        public readonly Image mainImage;

        public MainImage(Image mainImage)
        {
            this.mainImage = mainImage; 
        }
    }
}
