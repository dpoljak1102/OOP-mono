using Praksa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
//using Praksa.Service;
using Praksa.Repository.Common;

namespace Praksa.Repository
{
    public class PraksaPersonRepository : IPraksaPersonRepository
    {
        public List<Person> person = new List<Person>();
        public PraksaPersonRepository(){}

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Praksa;Integrated Security=True";
        
        //Get all people from base
        public List<Person> GetAllPeople()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Person;";

                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    person.Add(new Person { Id = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2), Age = reader.GetInt32(3) });
                }
                reader.Close();
                connection.Close();
            }
            return person;
        }

        //Update person
        public void UpdatePerson(Person person)
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
        }
        //Delete person
        public void DeletePerson(Person person)
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
        }
        //Add person
        public void AddPerson(Person person)
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
        }

        //

    }
}
