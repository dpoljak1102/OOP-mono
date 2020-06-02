using PraksaWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Web.Http;
using System.Web.UI;

namespace PraksaWebApplication.Controllers
{
    public class PraksaController : ApiController
    {
        List<Person> people = new List<Person>();

        //constructor
        public PraksaController()
        {
            people.Add(new Person { Id = 1, FirstName = "Fosoba1", LastName = "Losoba1", City = "City1" });
            people.Add(new Person { Id = 2, FirstName = "Fosoba2", LastName = "Losoba2", City = "City2" });
            people.Add(new Person { Id = 3, FirstName = "Fosoba3", LastName = "Losoba3", City = "City3" });
            people.Add(new Person { Id = 4, FirstName = "Fosoba4", LastName = "Losoba4", City = "City4" });
        }

        //Route to show only names
        [Route("api/Praksa/Names")]
        [HttpGet]
        public List<string> GetNames() 
        {
            List<string> names = new List<string>();
            foreach (var name in people)
            {
                names.Add(name.FirstName);
            }
            return names;
        }

        // GET: api/Praksa
        public List<Person> Get()
        {
            return people;
        }

        //existence of id
        public HttpResponseMessage GetId(int id)
        {
            var emp = people.Where(x => x.Id == id).FirstOrDefault();
            if (emp == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Id not found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, emp);
        }

        // POST: api/Praksa
        //public void Post([FromBody]string value)
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/Praksa/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Praksa/5
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid id");
            //dio s bazoom
            people.Remove(people.Where(x => x.Id == id).FirstOrDefault());

            return Ok();
        }
    }
}
