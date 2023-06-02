using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;

        }

        [HttpGet]
        // public ActionResult<List<Product>> GetProducts()
        // {
        //     var products = context.Products.ToList();
        //     return Ok(products);
        // }
        // ----======== scalable
        // for scalable reasons we can make the methods async like :
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();

        }

        [HttpGet("{id}")]
        // public ActionResult<Product> GetProduct(int id)
        // {
        //     return context.Products.Find(id);
        // }

        // -====== to async 
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}