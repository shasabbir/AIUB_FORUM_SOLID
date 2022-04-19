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
    public class AdminController : ApiController
    {

        [HttpGet]
        [Route("api/Admin")]
        public HttpResponseMessage Get()
        {
            var cp = AdminServices.Get();
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
        [Route("api/Admin/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = AdminServices.Get(id);
            if (cp == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cp);

            }

        }

        [Route("api/Admin/create")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel Admin)
        {
            AdminServices.Add(Admin);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }

        [Route("api/Admin/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(AdminModel Admin)
        {
            AdminServices.Edit(Admin);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/Admin/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            AdminServices.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }


    }
}
