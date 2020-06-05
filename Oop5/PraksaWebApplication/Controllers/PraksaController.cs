using PraksaWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using Praksa.Model;
using Praksa.Service;
using System.Web.Services.Description;



namespace PraksaWebApplication.Controllers
{
    public class PraksaController : ApiController
    {
        //Person class from  Praksa.Model.Person
        public List<Praksa.Model.Person> people =  new List<Praksa.Model.Person>();
        //Class from Service
        PraksaPersonService peopleService = new PraksaPersonService();

        //GIVE all people
        [HttpGet]
        [Route("api/Praksa/People")]
        public HttpResponseMessage GetAllPeople()
        {
            //Method from service to give list of ppl
            people = peopleService.GetAllPeople();
            return Request.CreateResponse(HttpStatusCode.OK, people);
        }
        //Give name,surname of person
        [HttpGet]
        [Route("api/Praksa/People/Names")]
        public HttpResponseMessage GetAllNames()
        {
            //Get all ppl from base
            people = peopleService.GetAllPeople();

            //Show client only names and surnames
            List<NamesRest> names = new List<NamesRest>();
            foreach (var person in people)
            {
                names.Add(new NamesRest { FirstName = person.FirstName, LastName = person.LastName});
            }
            return Request.CreateResponse(HttpStatusCode.OK, names);
        }


        //UPDATE Person
        [HttpPut]
        [Route("api/Praksa/People")]
        public HttpResponseMessage UpdatePerson([FromBody] Praksa.Model.Person person)
        {
            //check for valid data
            //here we can check for more like if clinet put correct name,lastname..etc..
            if (person != null)
            {
                //data is valid
                peopleService.UpdatePerson(person);
                return Request.CreateResponse(HttpStatusCode.OK,"Update done");
            }
            //data is empty
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }
        //DELETE Person
        [HttpDelete]
        [Route("api/Praksa/People")]
        public HttpResponseMessage DeletePerson([FromBody] Praksa.Model.Person person) 
        {
            if (person != null)
            {
                peopleService.DeletePerson(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Delete done ");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }

        //NEW person
        [HttpPost]
        [Route("api/Praksa/People")]
        public HttpResponseMessage AddPerson([FromBody] Praksa.Model.Person person)
        {
            //check valid data
            if (person != null) 
            {
                peopleService.AddPerson(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Add done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");

        }
    };
}
