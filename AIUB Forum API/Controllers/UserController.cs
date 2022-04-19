using AIUB_Forum_API.Auth;
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
        [AdminAccess]
        public HttpResponseMessage GetUsers()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.GetAllUsers());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [Route("api/users/{id}")]
        [HttpGet]
        public HttpResponseMessage GetUser(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.GetUser(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [Route("api/users/search/{search}")]
        [HttpGet]
        //[AdminAccess]
        //[ModeratorAccess]
        //[UserAccess]
        public List<UserModel> GetSearchUsers(string search)
        {

            return UserService.GetSearchUsers(search);
        }
        [Route("api/users/create")]
        [HttpPost]
        public HttpResponseMessage Create(UserModel user)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.AddUser(user) ? "Created" : "not Created");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }

        }
        [Route("api/users/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(UserModel user)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.EditUser(user) ? "Edited" : "not edited");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
        [Route("api/users/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserService.DeleteUser(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }

        }
    }
}
