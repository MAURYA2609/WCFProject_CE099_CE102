using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BookStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public bool AddBook(Books p)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into books(name,price,author) values (@name,@price,@author)";
            SqlParameter para1 = new SqlParameter("@name", p.Name);
            SqlParameter para2 = new SqlParameter("@price", p.Price);
            SqlParameter para3 = new SqlParameter("@author", p.Author);

            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                return false;
            }
            return true;
        }

        public bool DeleteBook(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete from books where id=@id";
            SqlParameter para = new SqlParameter("@id", id);

            cmd.Parameters.Add(para);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return true;
        }

        public DataSet GetAllBooks()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from books",
               @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "products");
            return ds;
        }

        public Books GetBook(int id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from books where id=@id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Books pr = new Books();
            if (reader.Read())
            {
                pr.ID = reader.GetInt32(0);
                pr.Name = reader.GetString(1);
                pr.Price = reader.GetDouble(2);
                pr.Author = reader.GetString(3);

            }
            else
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "No record found with given ID";
                throw new FaultException<NotFoundFolt>(nf);
            }
            reader.Close();
            cnn.Close();
            return pr;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Books UpdateBook(Books p)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "update books set name=@name,price=@price,author=@author where id=@id";
            SqlParameter para1 = new SqlParameter("@id", p.ID);
            SqlParameter para2 = new SqlParameter("@name", p.Name);
            SqlParameter para3 = new SqlParameter("@price", p.Price);
            SqlParameter para4 = new SqlParameter("@author", p.Author);

            cmd.Parameters.Add(para1);
            cmd.Parameters.Add(para2);
            cmd.Parameters.Add(para3);
            cmd.Parameters.Add(para4);
            cnn.Open();
            int reader = cmd.ExecuteNonQuery();
            cnn.Close();
            if (reader == 0)
            {
                NotFoundFolt nf = new NotFoundFolt();
                nf.Exception = "Some issue found in updating the book please try after some time!!";
                throw new FaultException<NotFoundFolt>(nf);
            }
            return p;
        }
    }
}
