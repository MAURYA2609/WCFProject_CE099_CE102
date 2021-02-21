using BookStoreClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreClient
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Our book collection ";
            if (!IsPostBack)
            {

                BindData();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addb.aspx");
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            BookStoreClient.ServiceReference1.Service1Client bo = new BookStoreClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            int ID = (int)e.Keys["Id"];
            Books b = new Books();
            string name = (string)e.NewValues["Name"];
            string author = (string)e.NewValues["Author"];
            double price = float.Parse((string)e.NewValues["Price"]);
            Label1.Text = name;
            b.ID = ID;
            b.Name = name;
            b.Price = price;
            b.Author = author;
            bo.UpdateBook(b);
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            BookStoreClient.ServiceReference1.Service1Client bo = new BookStoreClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            int ID = (int)e.Keys["Id"];
            bo.DeleteBook(ID);
            // Delete here the database record for the selected patientID

            BindData();
        }
        private void BindData()
        {
            BookStoreClient.ServiceReference1.Service1Client bo = new BookStoreClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");

            DataSet ds = bo.GetAllBooks();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

    }
}