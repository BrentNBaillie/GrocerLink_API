using System;
using System.Collections.Generic;
using System.Text;

namespace GrocerLink_Library.Retailers.Costco
{
    public class CostcoResponse
    {

        public class Doc
        {
            public bool item_disponzeroinv { get; set; }
            public bool item_fsa_eligible { get; set; }
            public string item_product_marketing_statement { get; set; } = string.Empty;
            public double item_location_pricing_salePrice { get; set; }
            public string item_as400_category { get; set; } = string.Empty;
            public bool item_image_swatchable { get; set; }
            public string item_collateral_primaryimage { get; set; } = string.Empty;
            public string item_product_price_in_cart_only { get; set; } = string.Empty;
            public List<string> item_pill_attributes { get; set; } = [];
            public string item_short_description { get; set; } = string.Empty;
            public List<string> Model_attr { get; set; } = [];
            public bool item_product_comparable { get; set; }
            public string item_product_short_description { get; set; } = string.Empty;
            public string item_as400_department { get; set; } = string.Empty;
            public bool item_product_status_disponzeroinv { get; set; }
            public string item_number { get; set; } = string.Empty;
            public List<string> EDD_CHUBSmallPack_attr { get; set; } = [];
            public List<string> item_rating_value { get; set; } = [];
            public bool item_product_image_swatchable { get; set; }
            public bool item_variableweight { get; set; }
            public string item_product_name { get; set; } = string.Empty;
            public List<string> Model_descriptive { get; set; } = [];
            public bool item_chdi_eligible { get; set; }
            public string item_name { get; set; } = string.Empty;
            public double item_location_pricing_pricePerUnit_price { get; set; }
            public List<string> Brand_attr { get; set; } = [];
            public double item_location_pricing_listPrice { get; set; }
            public bool item_buyable { get; set; }
            public double item_ratings { get; set; }
            public string item_eligible_for_review { get; set; } = string.Empty;
            public List<string> Gourmet_attr { get; set; } = [];
            public string item_review_ratings { get; set; } = string.Empty;
            public bool item_product_review_eligible { get; set; }
            public string image { get; set; } = string.Empty;
            public List<string> Type_of_Gift_Basket_Tower_attr { get; set; } = [];
            public bool item_status_published { get; set; }
            public string name { get; set; } = string.Empty;
            public List<string> item_manufacturing_skus { get; set; } = [];
            public List<string> item_product_marketing_features { get; set; } = [];
            public List<string> item_program_eligibility { get; set; } = [];
            public string description { get; set; } = string.Empty;
            public bool item_product_buyable { get; set; }
            public List<string> content_type { get; set; } = [];
            public List<string> Online_Only_attr_pill { get; set; } = [];
            public bool item_comparable { get; set; }
            public bool item_product_status_published { get; set; }
            public bool item_searchable { get; set; }
            public List<string> Occasion_Type_attr { get; set; } = [];
            public List<string> categoryPath_ss { get; set; } = [];
            public string group_id { get; set; } = string.Empty;
            public List<string> Online_Only_attr { get; set; } = [];
            public bool item_member_only { get; set; }
            public string item_classification_itemclass { get; set; } = string.Empty;
            public string item_product_primary_image { get; set; } = string.Empty;
            public string id { get; set; }
            public DateTime item_startDate { get; set; }
            public int item_product_status_backorderflag { get; set; }
            public int item_product_status_backorderqty { get; set; }
            public int item_review_count { get; set; }
            public int item_rating_average_value { get; set; }
            public int item_backorderqty { get; set; }
            public int item_backorderflag { get; set; }
            public int item_product_review_count { get; set; }
            public bool isFutureDate { get; set; }
            public string deliveryStatus { get; set; } = string.Empty;
            public string item_location_availability { get; set; } = string.Empty;
            public string item_location_stockStatus { get; set; } = string.Empty;
            public string item_location_itemNumber { get; set; } = string.Empty;
            public string item_location_locationNumber { get; set; } = string.Empty;
            public string item_location_fulfillment_restrictions_minQty { get; set; } = string.Empty;
            public string item_location_fulfillment_restrictions_maxQty { get; set; } = string.Empty;
            public string item_location_currencyCode { get; set; } = string.Empty;
            public bool hasSingleSku { get; set; }
            public double minSalePrice { get; set; }
            public double maxSalePrice { get; set; }
            public bool isItemInStock { get; set; }
            public List<Image> images { get; set; } = new List<Image>();
            public List<string> item_product_marketingcontent_keywords { get; set; } = [];
            public List<string> Quantity_attr { get; set; } = [];
            public List<string> Container_Size_attr { get; set; } = [];
            public List<string> Package_Net_Weight_attr { get; set; } = [];
            public List<string> Form_attr { get; set; } = [];
            public List<string> Dietary_Features_attr { get; set; } = [];
            public string inWarehouseStatus { get; set; } = string.Empty;
            public List<string> Number_of_Servings_attr { get; set; } = [];
            public List<string> Shelf_Life_attr { get; set; } = [];
            public List<string> Container_Type_attr { get; set; } = [];
            public List<string> Warehouse_Only_attr_pill { get; set; } = [];
            public List<string> Warehouse_Only_attr { get; set; } = [];
        }

        public class Image
        {
            public string item_collateral_primaryimage { get; set; } = string.Empty;
        }

        public class Response
        {
            public List<Doc> docs { get; set; } = new List<Doc>();
        }

        public class CostcoRoot
        {
            public Response response { get; set; } = new Response();
        }
    }
}
