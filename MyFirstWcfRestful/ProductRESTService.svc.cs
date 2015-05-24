﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfRestful
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRESTService : IProductRESTService
    {
        public List<Product> GetProductList()
        {
            return Products.Instant.ProductList;
        }
    }
}
