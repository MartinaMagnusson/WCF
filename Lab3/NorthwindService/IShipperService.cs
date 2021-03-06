﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShipperService" in both code and config file together.
    [ServiceContract(Namespace = "http://ShipperService")]
    public interface IShipperService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        Shipper GetShipper(string ID);
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        void SaveShipper(Shipper shipper);
    }
    [DataContract]
    public class Shipper
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}
