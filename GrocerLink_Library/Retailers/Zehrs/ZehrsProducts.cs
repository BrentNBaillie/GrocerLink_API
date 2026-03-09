using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library.Retailers.Zehrs
{
    public class ZehrsProducts
    {
        public string Retailer { get; private set; } = "Zehrs";
        public List<ProductTile> Products { get; set; } = new List<ProductTile>();
    }
}
