using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Microsoft.FourEightySeven.WebAPI.Filters
{
    public class BlackListAuthorizationAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var user = Thread.CurrentPrincipal;
            if (user == null)
            {
                return true;
            }

            var splitUsers = SplitString(Users);
            if (splitUsers.Contains(user.Identity.Name, StringComparer.OrdinalIgnoreCase))
            {
                return false;
            }

            var splitRoles = SplitString(Roles);
            return !splitRoles.Any(user.IsInRole);
        }
        private static IEnumerable<string> SplitString(string original)
        {
            if (string.IsNullOrEmpty(original))
            {
                return new string[0];
            }
            var split = from piece in original.Split(',')
                                        let trimmed = piece.Trim()
                                        where !string.IsNullOrEmpty(trimmed)
                                        select trimmed;
            return split.ToArray();
        }
    }
}