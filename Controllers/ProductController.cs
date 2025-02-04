using Microsoft.AspNetCore.Mvc;
using ProductRabbify.Context;
using ProductRabbify.DTOs;
using ProductRabbify.Models;

namespace ProductRabbify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public ProductResultDTO Get()
        {
            var products = _dbContext.Products.ToList();
            return new ProductResultDTO
            {
                Products = products,
            };
        }

        [HttpGet("{id}")]
        public ProductModel? Get(int id)
        {
            return _dbContext.Products.Where(product => product.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody] ProductModel product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductModel updateProduct)
        {
            var existingProduct = _dbContext.Products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = updateProduct.Name;
            existingProduct.Price = updateProduct.Price;
            existingProduct.Description = updateProduct.Description;
            existingProduct.Qtd = updateProduct.Qtd;

            _dbContext.SaveChanges();
            return Ok(existingProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = _dbContext.Products.FirstOrDefault(p => p.Id == id);

            if (productToDelete == null)
            {
                return NotFound();
            }

            _dbContext.Products.Remove(productToDelete);
            _dbContext.SaveChanges();
            return NoContent();
        }
    }
}
