namespace Hourly.Interface.Customer
{
    public interface ICustomerRepository
    {
        ICustomer GetCustomer(int id);
        bool UpdateCustomer(ICustomer enterpriseCustomer);
    }
}
