using System;
using System.Linq.Expressions;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.Specification.Core
{
    public abstract class CompositeSpecification<T> : ISpecification<T> where T : IDataEntity 
    {
        public abstract Expression<Func<T, bool>> ToExpression();
        // this method is really necessary??
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

        public Func<T, bool> CompileToDelegate()
        {
            return this.ToExpression().Compile();
        }
//        public ISpecification<T> Not(ISpecification<T> specification)
//        {
//            return new NotSpecification<T>(this, specification);
//        }
    }
}
