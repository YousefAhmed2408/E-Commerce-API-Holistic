using Web_Holistecc.Data;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.Repository_s.ProductRepo_s
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContextt _context;

        public ProductRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void addProduct(ProductDTO dto)
        {
            Product product = new Product()
            {
                ProductName = dto.ProductName,
                ProductDescription = dto.ProductDescription,
                Quantity = dto.Quantity,    
            };
            _context.products.Add(product);
            _context.SaveChanges();
        }
    }
}
