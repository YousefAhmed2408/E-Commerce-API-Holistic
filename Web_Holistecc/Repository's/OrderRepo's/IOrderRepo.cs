using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.DTO_s.ProductDTO_s;

namespace Web_Holistecc.Repository_s.OrderRepo_s
{
    public interface IOrderRepo
    {
        public List<OrderGetAllDTO> GetAll();

        public void AddOrder(OrderPostDTO dto);

       public void UpdateOrder(OrderPutDTO dto , int id);

        public void DeleteOrder(int id);

    }
}
