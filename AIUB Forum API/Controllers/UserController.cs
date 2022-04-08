using BLL.Entities;
using BLL.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class UserController : ApiController
    {
        [Route("api/users")]
        [HttpGet]
        public HttpResponseMessage GetUsers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.GetAllUsers());
        }
        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage GetUser(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, UserService.GetUser(id));
        }
        [Route("api/users/search/{search}")]
        [HttpGet]
        public List<UserModel> GetSearchUsers(string search)
        {
            return UserService.GetSearchUsers(search);
        }
        [Route("api/users/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel user)
        {
            UserService.AddUser(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/users/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(UserModel user)
        {
            UserService.EditUser(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/users/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            UserService.DeleteUser(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }
}
