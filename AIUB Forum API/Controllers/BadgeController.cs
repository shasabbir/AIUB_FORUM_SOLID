﻿using System.Collections.Generic;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class BadgeController : ApiController
    {
        // GET: api/Badge
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Badge/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Badge
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Badge/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Badge/5
        public void Delete(int id)
        {
        }
    }
}