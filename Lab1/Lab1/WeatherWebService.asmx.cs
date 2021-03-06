﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab1
{
    /// <summary>
    /// Summary description for Lab1WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab1WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Weather()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 5);
            string weather; 
            switch (randomNumber)
            {
                case 1:
                    weather = "molnigt";
                    break;
                case 2:
                    weather = "sol";
                    break;
                case 3:
                    weather = "snö";
                    break;
                case 4:
                    weather = "regn";
                    break;
                default:
                    weather = "åska";
                    break;
            }
            return "Imorgon bli det " + weather;
        }
    }
}
