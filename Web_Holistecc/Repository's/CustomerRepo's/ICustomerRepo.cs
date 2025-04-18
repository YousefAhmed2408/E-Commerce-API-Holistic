using Web_Holistecc.DTO_s.CustomerDTO_s;

namespace Web_Holistecc.Repository_s.CustomerRepo_s
{
    public interface ICustomerRepo
    {
        public void AddCustomer(CustomerDTOPost dto);

        public CustomerGetByIdDTO GetCustomer(int id);
    }
}
