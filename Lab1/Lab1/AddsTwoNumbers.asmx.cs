﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab1
{
    /// <summary>
    /// Summary description for AddsTwoNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddsTwoNumbers : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddNumbers(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
