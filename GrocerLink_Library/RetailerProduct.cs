using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library
{
    public class RetailerProduct
    {
        public string Retailer { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
