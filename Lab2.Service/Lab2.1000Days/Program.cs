using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Lab2._1000Days
{
    [ServiceContract(Namespace = "http://Lab2._1000Days")]
    public interface INext1000Days
    {
        [OperationContract]
        string CalculateNext1000Days(DateTime birthday);
    }
    public class Next1000Days : INext1000Days
    {
        public string CalculateNext1000Days(DateTime birthday)
        {
            var days = (DateTime.Now - birthday);
            return "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8080/Lab2._1000Days");
            ServiceHost serviceHost = new ServiceHost(typeof(Next1000Days), address);
            try
            {
                serviceHost.AddServiceEndpoint(typeof(INext1000Days),
                    new WSHttpBinding(),
                    "Next1000Days");
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
