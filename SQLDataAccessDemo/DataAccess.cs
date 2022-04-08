using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.Common;

namespace SQLDataAccessDemo
{
    public class DataAccess
    {
        public List<Person> GetPeople(string LastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DemoDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{LastName}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName",new {LastName = LastName}).ToList();
                return output;
            }
        }

        public void InsertPerson(int ID, string firstName, string lastName, string emailAdress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("DemoDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person() { ID = ID, FirstName = firstName, LastName = lastName, EmailAdress = emailAdress, PhoneNumber = phoneNumber});
                connection.Execute("dbo.People_Insert @ID, @FirstName,@LastName, @EmailAdress,@PhoneNumber", people);
            }
        }
    }
}
