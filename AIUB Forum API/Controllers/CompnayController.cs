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
    public class CompnayController : ApiController
    {
       
        [HttpGet]
        [Route("api/Company")]
        public HttpResponseMessage Get()
        {
            var cp=CompanyService.Get();
            if (cp.Count()==0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cp);

            }
  
        }

        [HttpGet]
        [Route("api/Company/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = CompanyService.Get(id);
            if (cp == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cp);

            }

        }
		
		[Route("api/Job/GetByCompanyName/{Company}")]
        [HttpGet]
        public HttpResponseMessage GetByPositionName(string Company)
        {
            var cp = CompanyService.GetByCompanyName(Company);
            return Request.CreateResponse(HttpStatusCode.OK, cp);

        }

        [Route("api/Company/create")]
        [HttpPost]
        public HttpResponseMessage Create(CompanyModel Company)
        {
            CompanyService.Add(Company);
            return Request.CreateResponse(HttpStatusCode.OK,"Created");
        }

        [Route("api/Company/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(CompanyModel Company)
        {
            CompanyService.Edit(Company);
            return Request.CreateResponse(HttpStatusCode.OK,"Edited");
        }

        [Route("api/Company/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            CompanyService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK,"Deleted");
        }

        
    }
}
