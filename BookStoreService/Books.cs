using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BookStoreService
{
    [DataContract]
    public class Books
    {
        int id;
        string name;
        double price;
        string author;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        [DataMember]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

    }
}