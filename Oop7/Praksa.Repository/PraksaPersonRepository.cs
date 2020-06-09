using Praksa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Praksa.Repository.Common;
using System.Runtime.InteropServices;

namespace Praksa.Repository
{
    public class PraksaPersonRepository : IPraksaPersonRepository
    {
        public List<Person> people = new List<Person>();
        Person person = null;
        public PraksaPersonRepository(){}

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Praksa;Integrated Security=True";
        
        //Get all people from base
        public  async Task<List<Person>> GetAllPeopleAsync()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Person;";

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    person = new Person();
                    person.Id = reader.GetInt32(0);
                    person.FirstName = reader.GetString(1);
                    person.LastName = reader.GetString(2);
                    person.Age = reader.GetInt32(3);
                    people.Add(person);
                }
                reader.Close();
                connection.Close();
                return await Task.FromResult(people);
            }
            
        }

        //Update person
        public async Task UpdatePersonAsync(Person person)
        {
            //query string for update person only name and surname
            string queryStringUpdate = "UPDATE Person SET First_name = '" + person.FirstName + "', Last_name = '" + person.LastName + "' WHERE ID_person ='" + person.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringUpdate, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
            }
            //timer
            await Task.Delay(2000);
        }
        //Delete person
        public async Task DeletePersonAsync(Person person)
        {
            //query string to delete person on id, name
            //example insted id,name we will have usrename and email for delete person
            //becouse person don't know his id in base
            string queryStringDelete = "DELETE FROM Person WHERE ID_person ='" + person.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringDelete, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
            }
            await Task.Delay(2000);
        }
        //Add person
        public async Task AddPersonAsync(Person person)
        {
            //query string to add new person
            string queryStringAdd = "INSERT INTO Person VALUES(ID_person = '" + person.Id + "', First_name = '" + person.FirstName + "', Last_name = '" + person.LastName + "', Age = '" + person.Age + "');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryStringAdd, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                connection.Close();
            }
            await Task.Delay(2000);
        }
    }
}
