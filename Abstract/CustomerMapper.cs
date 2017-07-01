using CustomerWebApp.Models;
using CustomerWebApp.ViewModel;

namespace CustomerWebApp.Abstract
{
    public class CustomerMapper : ICustomerMapper
    {
        public Customer GetCustomer(CustomerViewModel cvm)
        {
            var customer = new Customer();
            customer.CustomerID = cvm.CustomerID;
            customer.FirstName = cvm.FirstName ?? "";
            customer.Lastname = cvm.Lastname;
            customer.Address1 = cvm.Address1;
            customer.Address2 = cvm.Address2 ?? "";
            customer.Town = cvm.Town;
            customer.County = cvm.County ?? "";
            customer.Postcode = cvm.Postcode;
            customer.Age = cvm.Age;
            customer.EmailAddress = cvm.EmailAddress ?? "";
            return customer;
        }
    }
}