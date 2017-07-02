using CustomerWebApp.Abstract;
using CustomerWebApp.Models;
using CustomerWebApp.ViewModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomerWebApp
{
    [TestFixture]
    public class TestCustomerMapper
    {
        [Datapoints]
        string[] stringDataPoints = { "ValidValue", null, "" };

        [Theory]
        [Description("Test that, upon mapping, values are never null.")]
        public void TestGetCustomer(string firstName, string lastName, string address1, string address2, string town, string county, string postcode, string emailAddress)
        {
            int id = 0;
            int age = 20;

            var cvm = new CustomerViewModel();
            cvm.CustomerID = id;
            cvm.FirstName = firstName;
            cvm.Lastname = lastName;
            cvm.Address1 = address1;
            cvm.Address2 = address2;
            cvm.Town = town;
            cvm.County = county;
            cvm.Postcode = postcode;
            cvm.Age = age;
            cvm.EmailAddress = emailAddress;

            ICustomerMapper customerMapper = new CustomerMapper();
            Customer customer = customerMapper.GetCustomer(cvm);

            Assert.That(customer, Is.Not.Null, "Customer should not be null.");
            Assert.That(customer.FirstName, Is.Not.Null, "FirstName should not be null.");
            Assert.That(customer.Address2, Is.Not.Null, "Address2 should not be null.");
            Assert.That(customer.County, Is.Not.Null, "County should not be null.");
            Assert.That(customer.EmailAddress, Is.Not.Null, "EmailAddress should not be null.");
        }
    }
}
