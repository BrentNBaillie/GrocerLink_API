using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library
{
    public class Product
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Rating {  get; set; } = string.Empty;
        public List<string> Images { get; set; } = new List<string>();  
        public string Brand {  get; set; } = string.Empty;
        public string PricePerUnit {  get; set; } = string.Empty;
        public string Price {  get; set; } = string.Empty;
        public string Type {  get; set; } = string.Empty;
        public string Unit {  get; set; } = string.Empty;

    }
}
