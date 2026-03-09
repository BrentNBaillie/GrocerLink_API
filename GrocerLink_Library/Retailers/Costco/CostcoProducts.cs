using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library.Retailers.Costco
{
    public class CostcoProducts
    {
        public string Retailer { get; set; } = "Costco";
        public List<CostcoResponse.Doc> Products { get; set; } = new List<CostcoResponse.Doc>();
    }
}
