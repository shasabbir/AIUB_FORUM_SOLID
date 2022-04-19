using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Web_Api.Controllers
{
    public class ModeratorController : ApiController
    {

        [HttpGet]
        [Route("api/Moderator")]
        public HttpResponseMessage Get()
        {
            var cp = ModeratorServices.Get();
            if (cp.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cp);

            }

        }

        [HttpGet]
        [Route("api/Moderator/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = ModeratorServices.Get(id);
            if (cp == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cp);

            }

        }

        [Route("api/Moderator/create")]
        [HttpPost]
        public HttpResponseMessage Create(ModeratorModel Moderator)
        {
            ModeratorServices.Add(Moderator);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }

        [Route("api/Moderator/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(ModeratorModel Moderator)
        {
            ModeratorServices.Edit(Moderator);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/Moderator/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ModeratorServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }


    }
}
