using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeesService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeesService
    {
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        Employees GetEmployee(int ID);
        [OperationContract]
        [FaultContract(typeof(ApplicationException))]
        [FaultContract(typeof(SqlException))]
        void EditEmployee(Employees employee);
    }
    [DataContract]
    public class Employees
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string TitleOfCourtesy { get; set; }
        [DataMember]
        public DateTime BirthDate { get; set; }
        [DataMember]
        public DateTime HireDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
    }
}
