using System;
using System.Linq.Expressions;
using Xunit;
using StsOnlineShopApp.Infrastructure.DataEntity;
using System.Linq;
using Xunit.Abstractions;

namespace UnitTesting
{
    public class ItsPriceIsMoreThanSpecificationTest
    {
        private readonly ITestOutputHelper output;

        public ItsPriceIsMoreThanSpecificationTest(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void OnlyReturnProductWhosePriceIsMoreThan3000()
        {
            Expression<Func<Product, bool>> expression = product => product.Price > (decimal) 3.00;

            output.WriteLine(expression.Parameters.Single().ToString());

            Assert.Equal("hey", "hhh");

        }
    }
}
