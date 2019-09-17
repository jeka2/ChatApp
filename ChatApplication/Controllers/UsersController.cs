using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Npgsql;
using UserDataAccess;

namespace ChatApplication.Controllers
{
    public class UsersController : ApiController
    {
        UserDataAccess.DataBaseAccess db = new UserDataAccess.DataBaseAccess();
        // GET: api/Users
        public List<string> Get()
        {
            List<string> dt = db.MakeRequest();

            return dt;
        }

        // GET: api/Users/5
        public string Get(int id)
        {

            return "value";
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
