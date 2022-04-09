using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class VoteController : ApiController
    {
        // GET: api/Vote
        [Route("api/votes")]
        [HttpGet]
        public HttpResponseMessage GetVotes()
        {
            return Request.CreateResponse(HttpStatusCode.OK, VoteService.GetAllVotes());
        }
        [Route("api/votes/{id}")]
        [HttpGet]
        public HttpResponseMessage GetVote(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, VoteService.GetVote(id));
        }

        [Route("api/votes/create")]
        [HttpPost]
        public HttpResponseMessage Create(VoteModel vote)
        {
            VoteService.AddVote(vote);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/votes/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(VoteModel vote)
        {
            VoteService.EditVote(vote);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/votes/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            VoteService.DeleteVote(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
