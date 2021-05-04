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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPublisher_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SET IDENTITY_INSERT Publishers ON INSERT INTO Publishers(PublisherID, PublisherName, Address, City, PostalCode, Country, Phone) VALUES ('" + txtPublisherID.Text + "', '" + txtPublisherName.Text + "', '" + txtPublisherAddress.Text + "', '" + txtPublisherCity.Text + "', '" + txtPublisherPostal.Text + "', '" + txtPublisherCountry.Text + "', '" + txtPublisherNumber.Text + "') SET IDENTITY_INSERT  Publishers OFF";
            //cmd.CommandText = "SET IDENTITY_INSERT Publishers ON DELETE FROM Publishers SET IDENTITY_INSERT Publishers OFF";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}