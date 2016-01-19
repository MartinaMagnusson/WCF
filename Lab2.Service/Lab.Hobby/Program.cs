using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
namespace Lab.Hobby
{
    [ServiceContract(Namespace = "http://Lab.Hobby")]
    public interface IHobby
    {
        [OperationContract]
        string Shoes(string gender, string shoes, int size);
    }
    public class Hobby : IHobby
    {
        public string Shoes(string gender, string shoes, int size)
        {
            if ((gender == "Kvinna" && size >= 35 && size <= 41) || (gender == "Man" && size >= 37 && size <= 45))
                return string.Format("{0} finns i storlek {1}!", shoes, size);
            else
                return string.Format("{0} finns tyvärr inte i storlek {1}!", shoes, size);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Uri address = new Uri("http://localhost:8080/Lab.Hobby");
                ServiceHost serviceHost = new ServiceHost(typeof(Hobby), address);
                try
                {
                    serviceHost.AddServiceEndpoint(typeof(IHobby),
                        new WSHttpBinding(),
                        "Hobby");

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
}