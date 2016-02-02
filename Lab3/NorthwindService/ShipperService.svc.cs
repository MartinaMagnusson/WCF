using NorthwindService.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ShipperService : IShipperService
    {
        private NorthwindRepository repo = new NorthwindRepository();
        public Shipper GetShipper(string ID)
        {
            string queryString = @"SELECT [ShipperID],[CompanyName],[Phone] 
                                   FROM[NORTHWND].[dbo].[Shippers] 
                                   WHERE[ShipperID] = " + ID;
            try
            {
                var shipper = repo.GetShipper(queryString, new Shipper());
                if(shipper.ID == null)
                    throw new FaultException("Something went wrong");
                return shipper;
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
        public void SaveShipper(Shipper shipper)
        {
            try
            {
                repo.SaveShopper(shipper);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
