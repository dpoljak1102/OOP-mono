using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praksa.Service;
using Praksa.Model;
using Praksa.Repository.Common;
using Praksa.Service.Common;

namespace Praksa.Service
{
    public class PraksaPersonService: IPraksaPersonService
    {
        #region Constructor
        public PraksaPersonService(IPraksaPersonRepository repository)
        {
            this.Repository = repository; 
        }
        #endregion

        #region Properties
        protected IPraksaPersonRepository Repository { get; private set; }
        #endregion

        #region Methods
        //Get all
        public async Task<List<Person>> GetAllPeopleAsync() 
        {
            return await Repository.GetAllPeopleAsync();
        }

        //Update person
        public async Task UpdatePersonAsync(Person person)
        {
             await Repository.UpdatePersonAsync(person);
        }
        //Delete person
        public async Task DeletePersonAsync(Person person)
        {
             await Repository.DeletePersonAsync(person);
        }
        //Add person
        public async Task AddPersonAsync(Person person)
        {
            await Repository.AddPersonAsync(person);
        }
        #endregion
    }
}
