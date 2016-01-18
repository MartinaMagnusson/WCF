using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Lab2.Service.Age
{
    [ServiceContract(Namespace = "http://Lab2.Service.Age")]
    public interface IDays
    {
        [OperationContract]
        string GetAge(DateTime birthday);
    }
    public class Days : IDays
    {
        public string GetAge(DateTime birthday)
        {
            var days = (DateTime.Now - birthday);
            return string.Format("Du är {0} dagar gammal", days.Days);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8080/Lab2.Service.Age");
            ServiceHost serviceHost = new ServiceHost(typeof(Days), address);
            try
            {
                serviceHost.AddServiceEndpoint(typeof(IDays),
                    new WSHttpBinding(),
                    "Days");
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior();
                smBehavior.HttpGetEnabled = true;
                serviceHost.Description.Behaviors.Add(smBehavior);

                serviceHost.Open();
                Console.WriteLine("Tjänsten är öppen!");
                Console.WriteLine("Tryck enter för att avsluta");
                Console.ReadLine();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                throw;
            }
            finally
            {
                serviceHost.Close();
            }
        }
    }
}
