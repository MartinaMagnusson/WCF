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
        public List<NameDay> nameDay;
        public NameDay1()
        {
            nameDay = new List<NameDay>();
            AddToList();
        }
        private string ReadFromFile()
        {
            try
            {  
                using (StreamReader sr = new StreamReader("C:/Users/Martina/Documents/Skola/WCF/WCF/Lab1/Lab1/TextFileNameDay.txt"))
                {
                    var line = sr.ReadToEnd();
                    return line;
                }
            }
            catch (Exception e)
            {
                return "The file could not be read:" + e.Message;
            }
        }
        public void AddToList()
        {
            var array = ReadFromFile().Split('.');
            for (var i = 0; i < array.Length; i++)
            {
                var name = array[i].Split(',');
                if (i % 2 != 0)
                    nameDay.Add(new NameDay(array[(i - 1)], name.ToList()));
            }
        }


        [WebMethod]
        public string ReturnDay(string inputName)
        {
            var day = inputName + " har tyvärr ingen namnsdag";
            foreach (var item in nameDay)
            {
                foreach (var name in item.Names)
                {
                    if (name.Replace(" ", "").ToLower() == inputName.Replace(" ", "").ToLower())
                        day = item.Date;
                }
            }
            return day;
        }
    }
}