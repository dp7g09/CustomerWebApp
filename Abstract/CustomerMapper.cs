using System;
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

        public CustomerViewModel GetCustomerViewModel(Customer customer)
        {
            var customerViewModel = new CustomerViewModel();
            customerViewModel.CustomerID = customer.CustomerID;
            customerViewModel.FirstName = customer.FirstName ?? "";
            customerViewModel.Lastname = customer.Lastname;
            customerViewModel.Address1 = customer.Address1;
            customerViewModel.Address2 = customer.Address2 ?? "";
            customerViewModel.Town = customer.Town;
            customerViewModel.County = customer.County ?? "";
            customerViewModel.Postcode = customer.Postcode;
            customerViewModel.Age = customer.Age;
            customerViewModel.EmailAddress = customer.EmailAddress ?? "";
            return customerViewModel;
        }
    }
}