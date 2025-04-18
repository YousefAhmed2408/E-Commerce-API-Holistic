using Microsoft.EntityFrameworkCore;
using Web_Holistecc.Data;
using Web_Holistecc.DTO_s.CustomerDTO_s;
using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.DTO_s.ShoppingCartDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.Repository_s.CustomerRepo_s
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContextt _context;

        public CustomerRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddCustomer(CustomerDTOPost dto)
        {
            Customer customer = new Customer
            {
                CustomerName = dto.CustomerName,
                CustomerPhone = dto.CustomerPhone,
                EmailAddress = dto.EmailAddress,
                ShoppingCart = new ShoppingCart
                {
                    NumsOfItems = dto.ShoppingCart.NumsOfItems,
                },
                orders = dto.orders.Select(f => new Order
                {
                    TotalPrice = f.TotalPrice,
                }).ToList(),
            };

            _context.customers.Add(customer);   
            _context.SaveChanges();
        }

        public CustomerGetByIdDTO GetCustomer(int id)
        {
            var res = _context.customers
                 .Include(a => a.ShoppingCart)
                 .Include(s => s.orders)
                 .ThenInclude(w => w.products).FirstOrDefault(d => d.CustomerId == id);

            return new CustomerGetByIdDTO
            {
                CustomerName = res.CustomerName,
                CustomerPhone = res.CustomerPhone,
                EmailAddress= res.EmailAddress,
                ShoppingCart = new ShoppingCartDTO
                {
                    NumsOfItems = res.ShoppingCart.NumsOfItems
                },
                orders = res.orders.Select(r => new OrderDTOGetCustomer
                {
                    TotalPrice = r.TotalPrice,
                    products = r.products.Select(r => new ProductDTO
                    {
                        ProductName =   r.ProductName,
                        ProductDescription = r.ProductDescription,
                        Quantity = r.Quantity,
                    }).ToList(),
                }).ToList(),
            };
        }
    }
}
