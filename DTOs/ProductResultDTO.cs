using ProductRabbify.Models;

namespace ProductRabbify.DTOs
{
    public class ProductResultDTO
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}
