using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GrocerLink_Library
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    
    public class Component
    {
        public string componentId { get; set; } = string.Empty;
        public Data data { get; set; } = new Data();
    }

    public class Data
    {
        public List<ProductTile> productTiles { get; set; } = new List<ProductTile>();
    }

    public class InitialSearchData
    {
        public Layout layout { get; set; } = new Layout();
    }

    public class Layout
    {
        public Sections sections { get; set; } = new Sections();
    }

    public class MainContentCollection
    {
        public List<Component> components { get; set; } = new List<Component>();
    }

    public class PageProps
    {
        public InitialSearchData initialSearchData { get; set; } = new InitialSearchData();
    }

    public class Promotion
    {
        public string type { get; set; } = string.Empty;
        public object quantity { get; set; } = new object();
        public object savings { get; set; } = new object();
        public object value { get; set; } = new object();
        public string promoCode { get; set; } = string.Empty;
        public DateTime expiryDate { get; set; }
        public object title { get; set; } = new object();
        public object promoType { get; set; } = new object();
        public string pricingMethod { get; set; } = string.Empty;
        public string text { get; set; } = string.Empty;
        public string reward { get; set; } = string.Empty;
    }

    public class ProductImage
    {
        public string imageUrl { get; set; } = string.Empty;
        public string thumbnailUrl { get; set; } = string.Empty;
        public string smallUrl { get; set; } = string.Empty;
        public string mediumUrl { get; set; } = string.Empty;
        public string largeUrl { get; set; } = string.Empty;
        public string extraLargeUrl { get; set; } = string.Empty;
        public string smallRetinaUrl { get; set; } = string.Empty;
        public string mediumRetinaUrl { get; set; } = string.Empty;
        public string largeRetinaUrl { get; set; } = string.Empty;
    }

    public class Pricing
    {
        public string price { get; set; } = string.Empty;
        public string wasPrice { get; set; } = string.Empty;
        public string displayPrice { get; set; } = string.Empty;
        public object memberOnlyPrice { get; set; } = new object();
        public object mopDisplayPrice { get; set; } = new object();
        public object ehfTotal { get; set; } = new object();
        public object environmentalHandlingFee { get; set; } = new object();
        public string taxInfo { get; set; } = string.Empty;
    }

    public class PricingUnits
    {
        public string type { get; set; } = string.Empty;
        public string unit { get; set; } = string.Empty;
        public int interval { get; set; }
        public int minOrderQuantity { get; set; }
        public int maxOrderQuantity { get; set; }
        public bool weighted { get; set; }
    }

    public class Deal
    {
        public string type { get; set; } = string.Empty;
        public string text { get; set; } = string.Empty;
        public int points { get; set; }
        public string name { get; set; } = string.Empty;
        public DateTime? expiryDate { get; set; }
        public object dealPrice { get; set; } = new object();
    }

    public class ProductTile
    {
        public int index { get; set; }
        public List<Promotion> promotions { get; set; } = new List<Promotion>();
        public object ratings { get; set; } = new object();
        public string productId { get; set; } = string.Empty;
        public List<ProductImage> productImage { get; set; } = new List<ProductImage>();
        public string brand { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public string packageSizing { get; set; } = string.Empty;
        public Pricing pricing { get; set; } = new Pricing();
        public PricingUnits pricingUnits { get; set; } = new PricingUnits();
        public Deal deal { get; set; } = new Deal();
        public string link { get; set; } = string.Empty;
    }

    public class Root
    {
        public PageProps pageProps { get; set; } = new PageProps(); 
    }

    public class Sections
    {
        public MainContentCollection mainContentCollection { get; set; } = new MainContentCollection();
    }
}
