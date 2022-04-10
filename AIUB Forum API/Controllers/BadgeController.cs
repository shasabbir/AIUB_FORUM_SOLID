using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class BadgeController : ApiController
    {
        [Route("api/Badges")]
        [HttpGet]
        public HttpResponseMessage GetBadges()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BadgeService.GetAllBadges());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [Route("api/Badges/{id}")]
        [HttpGet]
        public HttpResponseMessage GetBadge(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BadgeService.GetBadge(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [Route("api/Badges/create")]
        [HttpPost]
        public HttpResponseMessage Create(BadgeModel badge)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BadgeService.AddBadge(badge) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
        [Route("api/Badges/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(BadgeModel badge)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BadgeService.EditBadge(badge) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
        [Route("api/Badges/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, BadgeService.DeleteBadge(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
    }
}
