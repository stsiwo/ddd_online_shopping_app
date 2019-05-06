using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        private readonly ISpecification<T> _left;
        private readonly ISpecification<T> _right;

        public OrSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this._left = left;
            this._right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            BinaryExpression andExpression = Expression.OrElse(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<T, bool>>(andExpression, leftExpression.Parameters.Single());
        }
    }
}
