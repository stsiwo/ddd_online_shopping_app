using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StsOnlineShopApp.Infrastructure.Specification.Core;
using Microsoft.Extensions.Primitives;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.Specification
{
    public interface ISpecificationBuilder<T> where T : IDataEntity
    {
        Func<T, bool> Build(Dictionary<string, StringValues> qs);
    }
}
