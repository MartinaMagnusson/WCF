using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Lab2.Service
{
    [ServiceContract(Namespace = "http://Lab2.Service")]
    public interface IBMI
    {
        [OperationContract]
        string CalculateBMI(int weight, int length);
    }
    public class BMI : IBMI
    {
        public string CalculateBMI(int weight, int length)
        {
            var bmi = weight / (length * length);
            return string.Format("Ditt BMI är {0}", bmi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri address = new Uri("http://localhost:8080/Lab2.Service");
            ServiceHost serviceHost = new ServiceHost(typeof(BMI), address);
            try
            {
                serviceHost.AddServiceEndpoint(typeof(IBMI),
                    new WSHttpBinding(),
                    "BMI");
                ServiceMetadataBehavior smBehavior = new ServiceMetadataBehavior();
                smBehavior.HttpGetEnabled = true;
                serviceHost.Description.Behaviors.Add(smBehavior);

                serviceHost.Open();
                Console.WriteLine("Tjänsten är öppen!");
                Console.WriteLine("Tryck enter frö att avsluta");
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
