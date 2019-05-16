using System;
using System.Linq.Expressions;
using StsOnlineShopApp.UI.DTO;

namespace StsOnlineShopApp.Infrastructure.Specification.Core
{
    // make sure this can be used only for IDTO not domain entities
    // this might be changed in future but for now it's ok
    public interface ISpecification<T> where T : IDTO
    {
        Expression<Func<T, bool>> ToExpression();
        bool IsSatisfiedBy(T o);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> Or(ISpecification<T> specification);

        //ISpecification<T> Not(ISpecification<T> specification);
    }
}
