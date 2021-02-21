using System;
using BookStoreService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace BookStoreHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host;
            Uri http = new Uri("http://localhost:8080/BookStoreService");
            host = new ServiceHost(typeof(BookStoreService.Service1), http);
            host.Open();
            Console.WriteLine("Hello Maurya");
            Console.ReadLine();
        }
    }
}
