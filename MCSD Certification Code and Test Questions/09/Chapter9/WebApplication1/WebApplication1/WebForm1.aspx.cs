using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MyRecord> myRecordList = new List<MyRecord>();

            myRecordList.Add(new MyRecord() { Id = 1, Name = "John" });
            myRecordList.Add(new MyRecord() { Id = 2, Name = "Sue" });
            myRecordList.Add(new MyRecord() { Id = 3, Name = "Jack" });

            DropDownList1.DataSource = myRecordList;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();

using (SqlConnection cn = new SqlConnection())
{

}
        }
    }

    public class MyRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}