using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab1
{
    /// <summary>
    /// Summary description for ComputerGamesWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ComputerGamesWebService : System.Web.Services.WebService
    {
        private string ReadFromFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("C:/Users/Martina/Documents/Skola/WCF/WCF/Lab1/Lab1/computerGames.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    var line = sr.ReadToEnd();
                    return line;
                }
            }
            catch (Exception e)
            {
                return "The file could not be read:" + e.Message;
            }
        }

        [WebMethod]
        public string[] ReturnListOfGame()
        {
            var listOfGame = ReadFromFile().Split('\n');
            return listOfGame;
        }
    }
}
