using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Praksa.Model;
using PraksaWebApplication.Models;

namespace PraksaWebApplication
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Praksa.Model.Person, NamesRest>().ReverseMap();
        }
    }
}