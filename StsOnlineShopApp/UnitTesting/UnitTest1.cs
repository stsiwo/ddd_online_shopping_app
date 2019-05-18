using System;
using Xunit;
using Xunit.Abstractions;
using Microsoft.AspNetCore.WebUtilities;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;
using StsOnlineShopApp.Domain.ProductAggregate;

namespace UnitTesting
{
    public class UnitTest1 : Test
    {
        public UnitTest1(ITestOutputHelper output) : base(output) { }
        [Fact]
        public void Test1()
        {

//            string sampleQS = "param1=v1&param2=v2&param3=v3";
//
//            Dictionary<string, StringValues> result = QueryHelpers.ParseQuery(sampleQS);
//
//            output.WriteLine(result.GetValueOrDefault("param1"));

            List<string> propertyList = QueryTypeEnum.ToList();

            foreach (var item in propertyList)
            {
                output.WriteLine(item);
            }

            Assert.Equal("a", "b");

        }

        [Fact]
        public void ShouldReturnListOfPropertiesOfQueryTypeEnumStaticClass()
        {

            List<string> propertyList = QueryTypeEnum.ToList();

            foreach (var item in propertyList)
            {
                output.WriteLine(item);
            }

            Assert.Equal("a", "b");

        }
    }
}
