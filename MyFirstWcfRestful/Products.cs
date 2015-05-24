using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyFirstWcfRestful
{
    [DataContract]
    public class Product
    {

        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Categoty { get; set; }
        [DataMember]
        public int Price { get; set; }

        
    }
    public partial class Products
    {
        private static readonly Products _instant = new Products();
        private Products() { }
        public static Products Instant
        {
            get { return _instant; }
        }

        public List<Product> ProductList
        {
            get { return _products;}
        }

        private List<Product> _products = new List<Product>()
        {
            new Product(){ProductId = 1,Name="Nokia",Categoty = "Phone",Price = 20000},
            new Product(){ProductId = 2,Name="Samsung",Categoty = "Phone",Price = 18000},
            new Product(){ProductId = 3,Name="Apple",Categoty = "Phone",Price = 25000},
            new Product(){ProductId = 4,Name="LG",Categoty = "Phone",Price = 20000}
        };
    }
}