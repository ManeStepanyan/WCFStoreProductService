using Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            var client = new ServiceReference1.ServiceClient("WSHttpBinding_IService");
            //  Productik p = new Productik(8, "KitKat", "Group10", 280);
            Productik p1 = new Productik(1, "KitKat", "Group10", 280);
            var result=  client.StoreProduct(p1);
            Console.WriteLine("Message is {0}, status is {1}", result.Message, result.Status);
            Console.ReadKey();
                
        }
    }
}
