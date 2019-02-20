using Microsoft.FourEightySeven.DataAccess;
using Microsoft.FourEightySeven.DataModel;
using Microsoft.FourEightySeven.WebAPI.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Microsoft.FourEightySeven.WebAPI.Controllers
{
    public class AccountsController : ApiController
    {
        public IEnumerable<Account> GetAccounts() => DataRepository.Accounts;
        [RequireHttpsAttribute]
        public Account GetAccount(int accountId)
        {
            var result = DataRepository.Accounts.SingleOrDefault(acc => acc.AccountId == accountId);
            if (result == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return result;
        }
    }
}
