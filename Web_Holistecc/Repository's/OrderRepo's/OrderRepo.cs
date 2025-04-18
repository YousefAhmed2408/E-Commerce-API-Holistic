using Microsoft.EntityFrameworkCore;
using Web_Holistecc.Data;
using Web_Holistecc.DTO_s.CustomerDTO_s;
using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.Repository_s.OrderRepo_s
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContextt _context;

        public OrderRepo(AppDbContextt context)
        {
            _context = context;
        }

        public void AddOrder(OrderPostDTO dto)
        {
            Order order = new Order()
            {
                TotalPrice = dto.TotalPrice,
                products = dto.products.Select(e => new Product
                {
                    ProductName = e.ProductName,
                    ProductDescription = e.ProductDescription,
                    Quantity = e.Quantity,
                }).ToList(),
                CustomerId = dto.CustomerId,
            };
            _context.orders.Add(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var res = _context.orders.FirstOrDefault(w => w.OrderId == id);
            if (res != null)
            {
                _context.orders.Remove(res);
                _context.SaveChanges();
            }
        }

        public List<OrderGetAllDTO> GetAll()
        {
           var res = _context.orders
                .Include(a => a.products)
                .Include(b => b.Customer).ToList();
            
            var ee = _context.orders.Select(e => new OrderGetAllDTO
            {
                TotalPrice = e.TotalPrice,
                Customer = new CustomerDTO 
                { 
                    CustomerName = e.Customer.CustomerName,
                    CustomerPhone = e.Customer.CustomerPhone,
                    EmailAddress = e.Customer.EmailAddress,
                },
                products = e.products.Select(s => new ProductDTO
                {
                    ProductName = s.ProductName,
                    ProductDescription = s.ProductDescription,
                    Quantity = s.Quantity,
                }).ToList()
            }).ToList();
            return ee;
        }

        public void UpdateOrder(OrderPutDTO dto, int id)
        {
           var res = _context.orders.
                Include(a => a.products).
                FirstOrDefault(w => w.OrderId == id);

            res.TotalPrice = dto.TotalPrice;
            res.products = dto.products.Select(a => new Product
            {
                ProductId = a.ProductId,
                ProductName = a.ProductName,
                ProductDescription = a.ProductDescription,
                Quantity = a.Quantity,
            }).ToList();

            _context.orders.Update(res);
            _context.SaveChanges();
        }
    }
}
