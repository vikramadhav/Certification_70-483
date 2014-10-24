using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Chapter9
{
    class ADONETSamples
    {
        static void Main(string[] args)
        {            
        }

        static void OpenConnection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.Open();
        }

        static void CommandExecuteNonQueryText()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Person (FirstName, LastName) VALUES ('Joe', 'Smith')";
            cmd.ExecuteNonQuery();

            cn.Close();
        }
        static void CommandExecuteNonQueryStoredProcedure()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PersonInsert";
            cmd.Parameters.Add(new SqlParameter("@FirstName", "Joe"));
            cmd.Parameters.Add(new SqlParameter("@LastName", "Smith"));
            cmd.ExecuteNonQuery();

            cn.Close();
        }
        static void CommandExecuteReader()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Person";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Debug.WriteLine(string.Format("First Name: {0} , Last Name: {1}", dr["FirstName"], dr["LastName"]));
                }
            }
            dr.Close();
            cn.Close();
        }

        static void CommandExecuteScalar()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM Person";
            object obj = cmd.ExecuteScalar();

            Debug.WriteLine(string.Format("Count: {0}", obj.ToString()));

            cn.Close();
        }

        static void CommandExecuteXmlReader()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Person FOR XML AUTO, XMLDATA";
            System.Xml.XmlReader xml = cmd.ExecuteXmlReader();

            cn.Close();
        }

        static void DataSetPopulate()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Person", cn);

            DataSet ds = new DataSet();
            da.Fill(ds, "Person");

            cn.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Debug.WriteLine(string.Format("First Name: {0} , Last Name: {1}", row["FirstName"], row["LastName"]));
            }

        }

        static void DataSetInsert()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Person", cn);

            //Create the insert command
            SqlCommand insert = new SqlCommand();
            insert.Connection = cn;
            insert.CommandType = CommandType.Text;
            insert.CommandText = "INSERT INTO Person (FirstName, LastName) VALUES (@FirstName, @LastName)";

            //Create the parameters
            insert.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName"));
            insert.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName"));

            //Associate the insert command with the DataAdapter.
            da.InsertCommand = insert;

            //Get the data.
            DataSet ds = new DataSet();
            da.Fill(ds, "Person");

            //Add a new row.
            DataRow newRow = ds.Tables[0].NewRow();
            newRow["FirstName"] = "Jane";
            newRow["LastName"] = "Doe";
            ds.Tables[0].Rows.Add(newRow);

            //Updat the database.
            da.Update(ds.Tables[0]);

            cn.Close();

        }

        static void DataSetUpdateDelete()
        {
            SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            cn.ConnectionString = "Server = (local); Database = Reflection; Trusted_Connection = True;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Person", cn);

            //Create the update command
            SqlCommand update = new SqlCommand();
            update.Connection = cn;
            update.CommandType = CommandType.Text;
            update.CommandText = "UPDATE Person SET FirstName = @FirstName, LastName = @LastName WHERE PersonId = @PersonId";

            //Create the parameters
            update.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar, 50, "FirstName"));
            update.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar, 50, "LastName"));
            update.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int, 0, "PersonId"));

            //Create the delete command
            SqlCommand delete = new SqlCommand();
            delete.Connection = cn;
            delete.CommandType = CommandType.Text;
            delete.CommandText = "DELETE FROM Person WHERE PersonId = @PersonId";

            //Create the parameters
            SqlParameter deleteParameter = new SqlParameter("@PersonId", SqlDbType.Int, 0, "PersonId");
            deleteParameter.SourceVersion = DataRowVersion.Original;
            delete.Parameters.Add(deleteParameter);

            //Associate the update and delete commands with the DataAdapter.
            da.UpdateCommand = update;
            da.DeleteCommand = delete;

            //Get the data.
            DataSet ds = new DataSet();
            da.Fill(ds, "Person");

            //Update the first row
            ds.Tables[0].Rows[0]["FirstName"] = "Jack";
            ds.Tables[0].Rows[0]["LastName"] = "Johnson";

            //Delete the second row.
            ds.Tables[0].Rows[1].Delete();

            //Updat the database.
            da.Update(ds.Tables[0]);

            cn.Close();
        }
    }
}
