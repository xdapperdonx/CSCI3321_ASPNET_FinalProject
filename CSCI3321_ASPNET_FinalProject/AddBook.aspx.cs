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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SET IDENTITY_INSERT Books ON INSERT INTO Books(BookID, Title, AuthorID, Price, PublishDate, PublisherID, GenreID, WordCount)  VALUES ('" + txtBookID.Text + "', '" + txtTitle.Text + "', '" + Convert.ToInt32(drpAuthorID.SelectedValue) + "', '" + txtPrice.Text + "', '" + txtPublishDate.Text + "', '" + Convert.ToInt32(drpPublisherID.SelectedValue) + "', '" + Convert.ToInt32(drpGenreID.SelectedValue) + "', '" + txtWordCount.Text + "') SET IDENTITY_INSERT Books OFF";
            //cmd.CommandText = "SET IDENTITY_INSERT Books ON DELETE FROM Books SET IDENTITY_INSERT Books OFF";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}