using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using BLL.Services;

namespace AIUB_Forum_API.Auth
{
    public class ModeratorAccess:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, "No token supplied");
            }
            else
            {
                if (!AuthService.ValidateToken(token.ToString()))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden, "Token Expired");
                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}