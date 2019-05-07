using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public class ScoreType
    {
        public readonly ScoreTypeEnum scoreType;

        public ScoreType(ScoreTypeEnum scoreTypeEnum)
        {
            this.scoreType = scoreTypeEnum; 
        }
    }
}
