using NorthwindService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeesService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeesService.svc or EmployeesService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class EmployeesService : IEmployeesService
    {
        private NorthwindRepo repo = new NorthwindRepo();
        public void EditEmployee(Employees employee)
        {
            try
            {
                repo.EditEmployee(employee);
            }
            catch (FaultException ex)
            {

                throw ex;
            }
        }

        public Employees GetEmployee(int ID)
        {
            var queryString = @"SELECT [EmployeeID]
                                     ,[LastName]
                                     ,[FirstName]
                                     ,[Title]
                                     ,[TitleOfCourtesy]
                                     ,[BirthDate]
                                     ,[HireDate]
                                     ,[Address]
                                     ,[City]
                                 FROM [NORTHWND].[dbo].[Employees]
                                 WHERE [EmployeeID] = " + ID;
            var employee = new Employees();
            try
            {
                return repo.GetEmployee(queryString, employee);
            }
            catch (FaultException ex)
            {

                throw ex;
            }

        }
    }
}
