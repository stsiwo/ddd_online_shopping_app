using System;
using System.Collections.Generic;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using Microsoft.Extensions.Primitives;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public abstract class SpecificationBuilder<T> : ISpecificationBuilder<T> where T : IDataEntity
    {
        // inject BaseSpecifcation class per dependency or per request (Autofac)
        protected ISpecification<T> _BaseSpecification;

        public SpecificationBuilder(ISpecification<T> baseSpecification)
        {
            this._BaseSpecification = baseSpecification;
        }

        public abstract Func<T, bool> Build(Dictionary<String, StringValues> qs);
    }
}
