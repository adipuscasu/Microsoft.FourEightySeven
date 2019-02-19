using Microsoft.FourEightySeven.DataAccess;
using Microsoft.FourEightySeven.DataModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.FourEightySeven.WebAPI.Filters;

namespace Microsoft.FourEightySeven.WebAPI.Controllers
{
    public class CustomersController : ApiController
    {
        [HttpGet]
        //[XmlOutput]
        public IEnumerable<Customer> GetCustomers()
        {
            return DataRepository.Customers;
        }
        [HttpGet]
        public IEnumerable<Customer> GetCustomers(int accountId)
        {
            return DataRepository.Customers.Where(customer =>
                customer.AccountId == accountId);
        }
        [HttpGet]
        public IEnumerable<Customer> SearchCustomers(string lastName)
        {
            return DataRepository.Customers.Where(customer =>
                customer.LastName.ToLower().Contains(lastName.ToLower()));
        }
    }
}