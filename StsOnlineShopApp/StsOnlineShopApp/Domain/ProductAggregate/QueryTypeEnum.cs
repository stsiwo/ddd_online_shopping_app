using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace StsOnlineShopApp.Domain.ProductAggregate
{
    public static class QueryTypeEnum
    {
        public static String KeyWord = "keyword";
        public static String MaxPrice = "maxprice";
        public static String MinPrice = "minprice";
        public static String Category = "category";
        public static String SubCategory = "subcategory";
        public static String ReviewScore = "reviewscore";
        public static String Review = "review";
        public static String Sort = "sort"; 

        public static List<string> ToList()
        {
            List<string> propertyList = new List<string>();

            foreach (PropertyInfo prop in typeof(QueryTypeEnum).GetProperties())
            {
                propertyList.Add(prop.PropertyType.Name);
            }

            return propertyList;
        }
    }
}
