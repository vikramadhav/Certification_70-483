using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Chapter8
{
    [DataMapping("FirstName", "FName")]
    [DataMapping("LastName", "LName")]
    class Person
    {
        public int PersonId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public bool GetPerson(int personId)
        {
            //Open the connection to the database.
            SqlConnection cn = new SqlConnection("Server=(local);Database=Reflection;Trusted_Connection=True;");
            cn.Open();

            //Retrieve the record.
            SqlCommand cmd = new SqlCommand(string.Format("SELECT * FROM Person WHERE PersonId = {0}", personId), cn);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return ReflectionExample.LoadClassFromSQLDataReader(this, dr);
        }
    }    
}
