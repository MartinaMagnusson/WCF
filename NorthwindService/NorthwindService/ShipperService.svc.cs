using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace NorthwindService
{
    public class ShipperService : IShipperService
    {
       
        private NorthwindRepository repo = new NorthwindRepository();
        public Shipper GetShipper(string ID)
        {
            string queryString = @"SELECT [ShipperID],[CompanyName],[Phone] 
                                   FROM[NORTHWND].[dbo].[Shippers] 
                                   WHERE[ShipperID] = " + ID;
            var shipper = new Shipper();

            return repo.GetShipper(queryString, shipper);
        }
        public void SaveShipper(Shipper shipper)
        {
            repo.SaveShopper(shipper);
        }
    }
}
