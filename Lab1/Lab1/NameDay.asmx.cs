using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab1
{
    /// <summary>
    /// Summary description for NameDay1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NameDay1 : System.Web.Services.WebService
    {
        private string ReadFromFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("C:/Users/Martina/Documents/Skola/WCF/WCF/Lab1/Lab1/TextFileNameDay.txt"))
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
        public string ReturnDay(string inputName)
        {
            var array = ReadFromFile().Split('.');
            var day = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToLower().Contains(inputName.ToLower()))
                    day = inputName + " har namnsdag den " + array[(i - 1)];
            }
            return day;
        }
    }
}
