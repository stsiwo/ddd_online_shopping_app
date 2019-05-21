using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

// maybe not use this Not Specification
namespace StsOnlineShopApp.Infrastructure.Specification.Core
{
//    public class NotSpecification<T> : CompositeSpecification<T>
//    {
//        private readonly ISpecification<T> _specification;
//
//        public NotSpecification(ISpecification<T> specification)
//        {
//            this._specification = specification;
//        }
//
//        public override Expression<Func<T, bool>> ToExpression()
//        {
//            Expression<Func<T, bool>> expression = this._specification.ToExpression();
//
//            UnaryExpression notExpression = Expression.Not(expression);
//
//            return Expression.Lambda<Func<T, bool>>(notExpression, expression.Parameters.Single());
//        }
//    }
}
