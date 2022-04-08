using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace AIUB_Forum_API.Controllers
{
    public class BadgeController : ApiController
    {
        [Route("api/Badges")]
        [HttpGet]
        public HttpResponseMessage GetBadges()
        {
            return Request.CreateResponse(HttpStatusCode.OK, BadgeService.GetAllBadges());
        }
        [Route("api/Badges/{id}")]
        [HttpGet]
        public HttpResponseMessage GetBadge(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, BadgeService.GetBadge(id));
        }
        [Route("api/Badges/create")]
        [HttpPost]
        public HttpResponseMessage Create(BadgeModel badge)
        {
            BadgeService.AddBadge(badge);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/Badges/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(BadgeModel badge)
        {
            BadgeService.EditBadge(badge);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/Badges/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            BadgeService.DeleteBadge(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
