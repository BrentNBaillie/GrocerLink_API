using GrocerLink_Library;
using Microsoft.AspNetCore.Mvc;

namespace GrocerLink_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSearchController : ControllerBase
    {
        private HttpClient client = new HttpClient();
        private readonly Dictionary<string,string?> stores;

        public ProductSearchController(IConfiguration config)
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
            stores = config.GetSection("RetailerSettings")
                .GetChildren()
                .ToDictionary(x => x.Key, x => x.Value);
        }

        [HttpGet("zehrs/{search}")]
        public async Task<ActionResult<RetailerProduct>> GetZehrsProducts(string search)
        {
            string url = stores["Zehrs"]!.Replace("{search}", search);
            Root? root = await client.GetFromJsonAsync<Root>(url);
            if (root is null) return BadRequest();
            List<ProductTile> productTiles = root.pageProps.initialSearchData.layout.sections.mainContentCollection.components.Where(c => c.componentId == "productGridComponent").ToList().SelectMany(c => c.data.productTiles).ToList();
            List<Product> products = productTiles.Select(p => {
                var image = p.productImage?.FirstOrDefault();

                return new Product
                {
                    Id = p.productId,
                    Name = p.title,
                    Description = p.description,
                    Rating = p.ratings?.ToString() ?? string.Empty,
                    Images = new List<string> {
                        image?.imageUrl ?? string.Empty,
                        image?.thumbnailUrl ?? string.Empty,
                    },
                    Brand = p.brand,
                    PricePerUnit = p.packageSizing,
                    Price = p.pricing.price,
                    Type = p.pricingUnits?.type ?? string.Empty,
                    Unit = p.pricingUnits?.unit ?? string.Empty
                };
            }).ToList();
            return Ok(new RetailerProduct { Retailer = "Zehrs", Products = products});
        }

        [HttpGet("nofrills/{search}")]
        public async Task<ActionResult<RetailerProduct>> GetNoFrillsProducts(string search)
        {
            string url = stores["NoFrills"]!.Replace("{search}", search);
            Root? root = await client.GetFromJsonAsync<Root>(url);
            if (root is null) return BadRequest();
            List<ProductTile> productTiles = root.pageProps.initialSearchData.layout.sections.mainContentCollection.components.Where(c => c.componentId == "productGridComponent").ToList().SelectMany(c => c.data.productTiles).ToList();
            List<Product> products = productTiles.Select(p => {
                var image = p.productImage?.FirstOrDefault();

                return new Product
                {
                    Id = p.productId,
                    Name = p.title,
                    Description = p.description,
                    Rating = p.ratings?.ToString() ?? string.Empty,
                    Images = new List<string> {
                        image?.imageUrl ?? string.Empty,
                        image?.thumbnailUrl ?? string.Empty,
                    },
                    Brand = p.brand,
                    PricePerUnit = p.packageSizing,
                    Price = p.pricing.price,
                    Type = p.pricingUnits?.type ?? string.Empty,
                    Unit = p.pricingUnits?.unit ?? string.Empty
                };
            }).ToList();
            return Ok(new RetailerProduct {Retailer = "NoFrills", Products = products });
        }

        [HttpGet("costco/{search}")]
        public async Task<ActionResult<RetailerProduct>> GetCostcoProducts(string search)
        {
            return Ok();
        }
    }
}
