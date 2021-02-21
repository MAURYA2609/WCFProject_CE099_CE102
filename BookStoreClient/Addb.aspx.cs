using BookStoreClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStoreClient
{
    public partial class Addb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            BookStoreClient.ServiceReference1.Service1Client bo = new BookStoreClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Books b = new Books();
            b.Name = TextBox1.Text;
            b.Price = float.Parse(TextBox4.Text);
            b.Author = TextBox3.Text;

            bo.AddBook(b);
            Response.Redirect("HomePage.aspx");
        }
    }
}