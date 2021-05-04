using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddAuthor_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SET IDENTITY_INSERT Authors ON INSERT INTO Authors(AuthorID, LastName, FirstName, Gender, BirthDate)  VALUES ('" + txtAuthorID.Text + "', '" + txtLastName.Text + "', '" + txtFirstName.Text + "', '" + txtGender.Text + "', '" + txtBirthDate.Text + "') SET IDENTITY_INSERT  Publishers OFF";
            //cmd.CommandText = "SET IDENTITY_INSERT Authors ON DELETE FROM Authors SET IDENTITY_INSERT Authors OFF";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}