using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();
        public bool IsSatisfiedBy(T o)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(o);
        }

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
        public ISpecification<T> Not(ISpecification<T> specification)
        {
            return new NotSpecification<T>(this, specification);
        }
    }
}
