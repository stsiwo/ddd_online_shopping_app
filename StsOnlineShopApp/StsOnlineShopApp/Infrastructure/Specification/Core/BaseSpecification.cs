using DataEntity = StsOnlineShopApp.Infrastructure.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.Specification.Core
{
    /**
     * this is for surrogate specification to setup initial specification 
     * therefore, alway return true;
     **/
    public class BaseSpecification : CompositeSpecification<DataEntity.Product>
    {
        public override Expression<Func<DataEntity.Product, bool>> ToExpression()
        {
            return product => true;
        }
    }
}
