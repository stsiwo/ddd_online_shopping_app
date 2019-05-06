using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> ToExpression();
        bool IsSatisfiedBy(T o);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> Or(ISpecification<T> specification);

        ISpecification<T> Not(ISpecification<T> specification);
    }
}
