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
//Povezivanje
//using Praksa.Model;
//using Praksa.Service;
using System.Web.Services.Description;

namespace PraksaWebApplication.Controllers
{
    public class PraksaController : ApiController
    {
        [HttpGet]
        [Route("api/Praksa/People")]
        public HttpResponseMessage GetAllPeople()
        {
            // trebali bi dobiti person iz service.GetAllPeopl
            // Trebali bi koristiti maper i napraviti ga 
            // return Request.CreateResponse(HttpStatusCode.OK, maper)
            return Request.CreateResponse(HttpStatusCode.OK);
        }




        //List<Person> people = new List<Person>();
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Praksa;Integrated Security=True";

        ////getall
        //[Route("api/Praksa/People")]
        //[HttpGet]
        //public List<Person> AllPeople()
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        string queryString = "SELECT * FROM Person;";

        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            people.Add(new Person { Id = reader.GetInt32(0), FirstName = reader.GetString(1), LastName = reader.GetString(2), Age = reader.GetInt32(3)});
        //        }
        //        reader.Close();
        //        connection.Close();
        //    }
        //    return people;
        //}

        ////update 
        //[Route("api/Praksa/People")]
        //[HttpPut]
        //public HttpResponseMessage UpdatePerson([FromBody] Person person)
        //{
        //    string queryStringUpdate = "UPDATE Person SET First_name = '" + person.FirstName + "', Last_name = '" + person.LastName + "' WHERE ID_person ='" + person.Id + "';";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        int checkMe = person.Id;
        //        if (checkMe < 0)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotFound, "Id not found");
        //        }

        //        SqlCommand command = new SqlCommand(queryStringUpdate, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        reader.Close();
        //        connection.Close();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //}

        ////delete
        //[Route("api/Praksa/People")]
        //[HttpDelete]
        //public HttpResponseMessage DeletePerson([FromBody] Person person)
        //{
        //    string queryStringDelete = "DELETE FROM Person WHERE ID_person ='" + person.Id + "';";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        int checkMe = person.Id;
        //        if (checkMe < 0)
        //        {
        //            return Request.CreateResponse(HttpStatusCode.NotFound, "Id not found");
        //        }

        //        SqlCommand command = new SqlCommand(queryStringDelete, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        reader.Close();
        //        connection.Close();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //}

        ////Add new
        //[Route("api/Praksa/People")]
        //[HttpPost]
        //public HttpResponseMessage AddPerson([FromBody] Person person)
        //{
        //    string queryStringInsert = "INSERT INTO Person VALUES(ID_person = '" + person.Id + "', First_name = '" + person.FirstName + "', Last_name = '" + person.LastName + "', Age = '" + person.Age + "');";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        int checkMe = person.Id;
        //        if (checkMe < 0)
        //        {
        //           return Request.CreateResponse(HttpStatusCode.NotFound, "Id not found");
        //        }


        //        SqlCommand command = new SqlCommand(queryStringInsert, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        reader.Close();
        //        connection.Close();
        //        return Request.CreateResponse(HttpStatusCode.OK);
        //    }
        //}

    };
}
