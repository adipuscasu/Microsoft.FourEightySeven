using System;
using System.Collections.Generic;
using System.Web.Http;
using Microsoft.FourEightySeven.DataModel;

namespace Microsoft.FourEightySeven.WebAPI
{
    public class CustomerController : ApiController
    {
        public IEnumerable<Customer> GetCustomers(int accountId)
        {
            throw new NotImplementedException("You still need to write this logic");
        }
        public IEnumerable<Customer> SearchCustomers(int accountId, string lastName)
        {
            throw new NotImplementedException("You still need to write this logic");
        }
    }
}