﻿using PraksaWebApplication.Models;
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
            //Get all ppl from base
            var allPeople =  await Service.GetAllPeopleAsync();
            if (allPeople != null)
            {
                //initialize Mapper
                var confgi = new MapperConfiguration(cfg => { cfg.CreateMap<Praksa.Model.Person, NamesRest>();});
                IMapper mapper = confgi.CreateMapper();
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