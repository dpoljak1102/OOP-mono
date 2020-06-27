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
using Praksa.Service.Common;
using System.Web.Services.Description;
using System.Threading.Tasks;
using AutoMapper;
using Praksa.Common;


namespace PraksaWebApplication.Controllers
{
    public class PraksaController : ApiController
    {
        #region Constructor
        public PraksaController(IPraksaPersonService service)
        {
            this.Service = service;
        }
        #endregion

        #region Properties
        protected IPraksaPersonService Service { get; private set;}
        #endregion

        List<NamesRest> names = new List<NamesRest>() { };

        // Filter,Page,Sort
        // URI EXAMPLE
        //      https://localhost:44373/api/Praksa/PeopleTest/?name=name
        //      https://localhost:44373/api/Praksa/PeopleTest/?name&ascDesc=desc
        //      https://localhost:44373/api/Praksa/PeopleTest/?name=name2&last=lastname3
        [HttpGet]
        [Route("api/Praksa/PeopleTest/")]
        public async Task<HttpResponseMessage> GetAllPeopleAsync(string name, string last = "", string ascDesc = "")
        {
            
            var page = new Pages();
            var filter = new Filters();
            var sorting = new Sorts();

            // 1. Da bi mogli search koristiti korisnik mora barem "name" napisati  kako bi mogao pretrazivati
            // 2. Korisnik ne mora puno ime napisati moze cak i pocetno slovo
            // 3. Dodatno moze koristiti i "last" da pretrazuje po prezimenu osobu
            // 4. Moze asc ili desc koristiti za age  (harkodirano zbog malo atributa u tablici)

            filter.FirstName = name;
            filter.LastName = last;

            page.PageSize = 5;
            //Age harkodirano zato sto imamo malo atributa u tablici pa cisto radi testiranja je stavjeno Age
            sorting.OrderBy = "Age";
            sorting.AscDesc = ascDesc;

            var allPeople = await Service.GetAllPeopleAsync(filter, page, sorting );
            if (allPeople != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, allPeople);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not Found");            
        }

        //GIVE all people
        [HttpGet]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> GetAllPeopleAsync()
        {
            var allPeople = await Service.GetAllPeopleAsync();
            if (allPeople != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, allPeople);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not Found");
        }


        //Give name,surname of person
        [HttpGet]
        [Route("api/Praksa/People/Names")]
        public async Task<HttpResponseMessage> GetAllNamesAsync()
        {
            var allPeople = await Service.GetAllPeopleAsync();
            if (allPeople != null)
            {
                //initialize Mapper
                var config = new MapperConfiguration(cfg => { cfg.CreateMap<Praksa.Model.Person, NamesRest>(); });
                IMapper mapper = config.CreateMapper();
                foreach (var person in allPeople)
                {
                    NamesRest namesRest = mapper.Map<Praksa.Model.Person, NamesRest>(person);
                    names.Add(namesRest);
                }
                return Request.CreateResponse(HttpStatusCode.OK, names);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
        }

        //UPDATE Person
        [HttpPut]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> UpdatePersonAsync([FromBody] Praksa.Model.Person person)
        {
            if (person != null)
            {
                await Service.UpdatePersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK,"Update done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }

        //DELETE Person
        [HttpDelete]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> DeletePersonAsync([FromBody] Praksa.Model.Person person) 
        {
            if (person != null)
            {
                await Service.DeletePersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Delete done ");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }

        //NEW person
        [HttpPost]
        [Route("api/Praksa/People")]
        public async Task<HttpResponseMessage> AddPersonAsync([FromBody] Praksa.Model.Person person)
        {
            if (person != null) 
            {
                await Service.AddPersonAsync(person);
                return Request.CreateResponse(HttpStatusCode.OK, "Add done");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Not valid data");
        }
    };
}
