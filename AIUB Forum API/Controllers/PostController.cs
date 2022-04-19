using AIUB_Forum_API.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace AIUB_Forum_API.Controllers
{
    public class PostController : ApiController
    {
        [HttpGet]
        [AdminAccess]
        [Route("api/Post/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
            
        }
        [HttpGet]
        [Route("api/Post/getall/")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
            
        }
        [HttpPost]
        [Route("api/Post/add")]
        public HttpResponseMessage Add(PostModel p)
        {
            try
            {
                if (PostServices.Add(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "added");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/edit")]
        public HttpResponseMessage Edit(PostModel p)
        {
            try
            {
                if (PostServices.Edit(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edited");
                }
                else
                {

                    return Request.CreateResponse(HttpStatusCode.OK, "not Edited");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/delete/{id}")]
        public HttpResponseMessage Del(int id)
        {
            try
            {
                if (PostServices.Delete(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }








        [HttpGet]
        [Route("api/Post/answer/get/{id}")]
        public HttpResponseMessage Getans(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpGet]
        [Route("api/Post/answer/getall/")]
        public HttpResponseMessage GetAllans()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpPost]
        [Route("api/Post/answer/add")]
        public HttpResponseMessage Addans(AnswerModel p)
        {
            try
            {
                if (AnswerServices.Add(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "added");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/answer/edit")]
        public HttpResponseMessage Editans(AnswerModel p)
        {
            try
            {
                if (AnswerServices.Edit(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edited");
                }
                else
                {

                    return Request.CreateResponse(HttpStatusCode.OK, "not Edited");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/answer/delete/{id}")]
        public HttpResponseMessage Delans(int id)
        {
            try
            {
                if (AnswerServices.Delete(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }








        [HttpGet]
        [Route("api/Post/comment/get/{id}")]
        public HttpResponseMessage Getcmt(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpGet]
        [Route("api/Post/comment/getall/")]
        public HttpResponseMessage GetAllcmt()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpPost]
        [Route("api/Post/comment/add")]
        public HttpResponseMessage Addcmt(CommentModel p)
        {
            try
            {
                if (CommentServices.Add(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "added");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/comment/edit")]
        public HttpResponseMessage Editcmt(CommentModel p)
        {
            try
            {
                if (CommentServices.Edit(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edited");
                }
                else
                {

                    return Request.CreateResponse(HttpStatusCode.OK, "not Edited");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/comment/delete/{id}")]
        public HttpResponseMessage Delcmt(int id)
        {
            try
            {
                if (CommentServices.Delete(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }








        [HttpGet]
        [Route("api/Post/answercomment/get/{id}")]
        public HttpResponseMessage Getanscmt(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpGet]
        [Route("api/Post/answercomment/getall/")]
        public HttpResponseMessage GetAllanscmt()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }

        }
        [HttpPost]
        [Route("api/Post/answercomment/add")]
        public HttpResponseMessage Addanscmt(AnswerCommentModel p)
        {
            try
            {
                if (AnswerCommentServices.Add(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "added");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/answercomment/edit")]
        public HttpResponseMessage Editanscmt(AnswerCommentModel p)
        {
            try
            {
                if (AnswerCommentServices.Edit(p))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Edited");
                }
                else
                {

                    return Request.CreateResponse(HttpStatusCode.OK, "not Edited");
                }
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }
        [HttpPost]
        [Route("api/Post/answercomment/delete/{id}")]
        public HttpResponseMessage Delanscmt(int id)
        {
            try
            {
                if (AnswerCommentServices.Delete(id))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
    }
}
