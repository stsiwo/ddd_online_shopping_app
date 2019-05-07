using System;
using System.Linq.Expressions;
using Xunit;
using StsOnlineShopApp.Infrastructure.DataEntity;
using System.Linq;
using Xunit.Abstractions;
using System.Collections.Generic;
using StsOnlineShopApp.Infrastructure.Specification;
using StsOnlineShopApp.Infrastructure.Specification.Core;

namespace UnitTesting
{
    public class ItsPriceIsMoreThanSpecificationTest
    {
        private readonly ITestOutputHelper output;

        public ItsPriceIsMoreThanSpecificationTest(ITestOutputHelper output)
        {
            this.output = output;
            // use this when want to check something in console
            // output.WriteLine(expression.Parameters.Single().ToString());
        }
        [Fact]
        public void OnlyReturnProductWhosePriceIsMoreThan3000()
        {
            IList<Product> myList = new List<Product>
            {
                new Product("1", "product_1", 3000.00m),
                new Product("2", "product_2", 2000.010m),
                new Product("3", "product_3", 3001.06m),
                new Product("4", "product_4", 2200.010m)
            };

            ISpecification<Product> itsPriceIsMoreThanSpecification = new ItsPriceIsMoreThanSpecification(3000.00m);

            IEnumerable<Product> expected = myList.Where(itsPriceIsMoreThanSpecification.ToExpression().Compile());

            Assert.Equal("product_3", expected.Single().Name);
        }
        
        // And Functionality test
        [Fact]
        public void shouldReturnProductIsLessThan2500AndMoreThan2000()
        {
            IList<Product> myList = new List<Product>
            {
                new Product("1", "product_1", 3000.00m),
                new Product("2", "product_2", 2000.00m),
                new Product("3", "product_3", 3001.06m),
                new Product("4", "product_4", 2200.010m)
            };

            ISpecification<Product> ProductIsLessThan2500AndMoreThan2000sSpecification = new ItsPriceIsMoreThanSpecification(2000.00m).And(new ProductPriceIsLessThanSpecification(2500.00m));

            IEnumerable<Product> expected = myList.Where(ProductIsLessThan2500AndMoreThan2000sSpecification.ToExpression().Compile());

            Assert.Equal("product_4", expected.Single().Name);
        }

        // Or Functionality test
        [Fact]
        public void shouldReturnProductIsLessThan3000OrMoreThan2001()
        {
            IEnumerable<Product> myList = new List<Product>
            {
                new Product("1", "product_1", 3000.00m),
                new Product("2", "product_2", 2000.00m),
                new Product("3", "product_3", 3001.06m),
                new Product("4", "product_4", 2200.010m)
            };

            ISpecification<Product> ProductIsLessThan3000OrMoreThan2001sSpecification = new ItsPriceIsMoreThanSpecification(3000.00m).Or(new ProductPriceIsLessThanSpecification(2001.00m));

            IEnumerable<Product> expected = myList.Where(ProductIsLessThan3000OrMoreThan2001sSpecification.ToExpression().Compile()).ToList();

            Assert.Equal("2", expected.Count().ToString());
            Assert.Contains<Product>(expected, p => p.Name == "product_2");
            Assert.Contains<Product>(expected, p => p.Name == "product_3");
        }
    }
}
