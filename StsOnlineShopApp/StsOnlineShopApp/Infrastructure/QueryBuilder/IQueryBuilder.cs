using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using StsOnlineShopApp.Infrastructure.DataEntity;

namespace StsOnlineShopApp.Infrastructure.QueryBuilder
{
    interface IQueryBuilder<T> 
        where T : IDataEntity
    {
        List<T> Build(AppDbContext appDbContext, Dictionary<string, StringValues> qs = null);

    }
}
