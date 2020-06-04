using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Service;
using Praksa.Model;
using Praksa.Repository;
using PraksaWebApplication.Controllers;
using Praksa.Service.Common;

namespace Praksa.Service
{
    public class PraksaPersonService: IPraksaPersonService
    {
        public List<Person> people = new List<Person>();
        public List<Person> GetAllPeople() {
            //Treba vracati
            //return Repository.GettAllPeople();
            //Pozivamo Repository i vracamo objekte iz baze odnosno osobe
            return null;
        }
    }
}
