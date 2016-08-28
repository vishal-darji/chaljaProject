using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myFirstWebApi.App_Code
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

    }
}