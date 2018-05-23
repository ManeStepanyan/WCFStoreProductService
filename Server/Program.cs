using StoreProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am server");
            Uri address = new Uri("http://localhost:9021/Productik/");
            WSHttpBinding binding = new WSHttpBinding();
            ServiceHost host = new ServiceHost(typeof(Service), address);
            host.AddServiceEndpoint(typeof(IService), binding, address);
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true; /// 
            host.Description.Behaviors.Add(smb);
            host.Open();
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();

            // Close the host to shutdown the service.  
            host.Close();
        }
    }
}
