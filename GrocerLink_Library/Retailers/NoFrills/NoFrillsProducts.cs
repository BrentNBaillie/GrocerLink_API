using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library.Retailers.NoFrills
{
    public class NoFrillsProducts
    {
        public string Retailer { get; private set; } = "NoFrills";
        public List<ProductTile> Products { get; set; } = new List<ProductTile>();
    }
}
