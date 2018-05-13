using CustomerWebApp.Models;
using CustomerWebApp.ViewModel;

namespace CustomerWebApp.Abstract
{
    public interface ICustomerMapper
    {
        Customer GetCustomer(CustomerViewModel cvm);

        CustomerViewModel GetCustomerViewModel(Customer customer);
    }
}
