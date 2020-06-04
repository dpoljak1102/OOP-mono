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
    public class PraksaPersonRepository: IPraksaPersonRepository
    {
        public List<Person> people = new List<Person>();
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Praksa;Integrated Security=True";
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
                    people.Add(new Person { Id = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2), Age = reader.GetInt32(3) });
                }
                reader.Close();
                connection.Close();
            }
            return people;
        }
    }
}
