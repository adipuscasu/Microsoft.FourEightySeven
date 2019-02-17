using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http.Filters;

namespace Microsoft.FourEightySeven.WebAPI.Filters
{
    public class XmlOutputAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response.Content is ObjectContent content)
            {
                var value = content.Value;
                var targetType = actionExecutedContext.Response.Content.
                    GetType().GetGenericArguments()[0];
                var httpResponseMessage = new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    RequestMessage = actionExecutedContext.Request,
                    Content = new ObjectContent(targetType, value,
                        new XmlMediaTypeFormatter(), (string)null)
                };
                actionExecutedContext.Response = httpResponseMessage;
            }

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}