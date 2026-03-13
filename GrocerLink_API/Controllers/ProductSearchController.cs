using GrocerLink_Library;
using GrocerLink_Library.Retailers.Costco;
using GrocerLink_Library.Retailers.NoFrills;
using GrocerLink_Library.Retailers.Zehrs;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
        public async Task<ActionResult<ZehrsProducts>> GetZehrsProducts(string search)
        {
            string url = stores["Zehrs"]!.Replace("{search}", search);
            Root? root = await client.GetFromJsonAsync<Root>(url);
            if (root is null) return BadRequest();
            List<ProductTile> products = root.pageProps.initialSearchData.layout.sections.mainContentCollection.components.Where(c => c.componentId == "productGridComponent").ToList().SelectMany(c => c.data.productTiles).ToList();
            return Ok(new ZehrsProducts { Products = products});
        }

        [HttpGet("nofrills/{search}")]
        public async Task<ActionResult<NoFrillsProducts>> GetNoFrillsProducts(string search)
        {
            string url = stores["NoFrills"]!.Replace("{search}", search);
            Root? root = await client.GetFromJsonAsync<Root>(url);
            if (root is null) return BadRequest();
            List<ProductTile> products = root.pageProps.initialSearchData.layout.sections.mainContentCollection.components.Where(c => c.componentId == "productGridComponent").ToList().SelectMany(c => c.data.productTiles).ToList();
            return Ok(new NoFrillsProducts { Products = products });
        }

        [HttpGet("costco/{search}")]
        public async Task<ActionResult<CostcoProducts>> GetCostcoProducts(string search)
        {
            return Ok();
        }
    }
}
