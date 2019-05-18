using System;
using System.Linq.Expressions;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.Specification.Core
{
    public interface ISpecification<T> where T : IDataEntity
    {
        Expression<Func<T, bool>> ToExpression();
        bool IsSatisfiedBy(T o);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> Or(ISpecification<T> specification);

        Func<T, bool> CompileToDelegate();

        //ISpecification<T> Not(ISpecification<T> specification);
    }
}
