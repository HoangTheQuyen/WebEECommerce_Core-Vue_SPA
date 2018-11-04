using System.Threading.Tasks;
using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebEECommerce_Core_Vue_SPA.Features.Products
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly EcommerceContext context;
        public ProductsController(EcommerceContext ctx) => context = ctx;

        [HttpGet]
        public async Task<IActionResult> Find()
        {
            var products = await context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{slug}")]
        public async Task<IActionResult> Get(string slug)
        {
            var product = await context.Products.SingleOrDefaultAsync(x =>
            x.Slug == slug);

            if (product == null) return NotFound();
            
            return Ok(product);
        }
    }
}