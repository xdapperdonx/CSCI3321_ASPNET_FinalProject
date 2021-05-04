﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class MyBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// TODO: Dynamiclly build your book collection with the following information
            /// 1. Book title
            /// 2. Author's LastName and FirstName
            /// 3. Price
            /// 4. Publish date
            /// 5. Publisher's name
            /// 6. Genre
            /// 
            // 1. Create a SqlConnection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            // 2. Create a SqlCommand object using the above connection object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Books.Title, Authors.LastName, Authors.FirstName, Books.Price, Books.PublishDate, Genres.GenreName, Publishers.PublisherName FROM Books, Authors, Genres, Publishers WHERE Authors.AuthorID=Books.AuthorID AND Genres.GenreID=Books.GenreID AND Publishers.PublisherID=Books.PublisherID";//SELECT Books.Title, Authors.LastName, Authors.FirstName, Books.Price, Genres.GenreName FROM Books, Authors, Genres WHERE Authors.AuthorID=Books.AuthorID AND Genres.GenreID=Books.GenreIDBooks.AuthorID

            // 3. Open the connection and execute the command
            // store the returned data in a SqlDataReader object
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. if there is data in the SqlDataReader object
            // then loop through each record to build the table to display the books
            if (reader.HasRows)
            {
                // Build the table 
                while (reader.Read())
                {
                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();

                    tc = new TableCell();
                    tc.Text = reader["Title"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["LastName"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["FirstName"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["Price"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["PublishDate"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["PublisherName"].ToString();
                    tr.Cells.Add(tc);

                    tc = new TableCell();
                    tc.Text = reader["GenreName"].ToString();
                    tr.Cells.Add(tc);

                    tblBookCollection.Rows.Add(tr);
                }
            }
        }
    }
}