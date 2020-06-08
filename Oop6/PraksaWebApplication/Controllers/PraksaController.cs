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
using System.Threading.Tasks;
using AutoMapper;


namespace PraksaWebApplication.Controllers
{
    public class PraksaController : ApiController
    {
        public List<Praksa.Model.Person> people =  new List<Praksa.Model.Person>();
        PraksaPersonService peopleService = new PraksaPersonService();
        //model from controller
        List<NamesRest> names = new List<NamesRest>() { };

        //GIVE all people
        [HttpGet]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> GetAllPeopleAsync()
        {
            //Method from service to give list of ppl
            people = await peopleService.GetAllPeopleAsync();
            if (people != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, people);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "People not found");            
        }

        //Give name,surname of person
        [HttpGet]
        [Route("api/Praksa/People/Names")]
        public async Task<HttpResponseMessage> GetAllNamesAsync()
        {
            //Get all ppl from base
            people =  await peopleService.GetAllPeopleAsync();
            if (people != null)
            {
                //initialize Mapper
                var confgi = new MapperConfiguration(cfg => { cfg.CreateMap<Praksa.Model.Person, NamesRest>();});
                IMapper mapper = confgi.CreateMapper();
                foreach (var person in people)
                {
                    NamesRest namesRest = mapper.Map<Praksa.Model.Person, NamesRest>(person);
                    names.Add(namesRest);
                }

                return Request.CreateResponse(HttpStatusCode.OK, names);

                //Show client only names and surnames
                //foreach (var person in people)
                //{
                //    names.Add(new NamesRest { FirstName = person.FirstName, LastName = person.LastName });
                //}
                //return Request.CreateResponse(HttpStatusCode.OK, names);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
        }

        //UPDATE Person
        [HttpPut]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> UpdatePersonAsync([FromBody] Praksa.Model.Person person)
        {
            //check for valid data
            //here we can check for more like if clinet put correct name,lastname..etc..
            if (person != null)
            {
                //data is valid
                await peopleService.UpdatePersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK,"Update done");
            }
            //data is empty
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }

        //DELETE Person
        [HttpDelete]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> DeletePersonAsync([FromBody] Praksa.Model.Person person) 
        {
            if (person != null)
            {
                await peopleService.DeletePersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Delete done ");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }

        //NEW person
        [HttpPost]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> AddPersonAsync([FromBody] Praksa.Model.Person person)
        {
            //check valid data
            if (person != null) 
            {
                await peopleService.AddPersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Add done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }
    };
}
