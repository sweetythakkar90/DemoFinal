namespace Hourly.Interface.Customer
{
    public interface ICustomerService
    {
        ICustomer GetCustomer(int id);
        bool UpdateCustomer(ICustomer enterpriseCustomer);
    }
}
