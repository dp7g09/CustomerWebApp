using CustomerWebApp.Models;
using CustomerWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp.Abstract
{
    public interface ICustomerMapper
    {
        Customer GetCustomer(CustomerViewModel cvm);

        CustomerViewModel GetCustomerViewModel(Customer customer);
    }
}
