using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NorthwindService.Repository
{
    public class NorthwindRepo
    {
        private readonly string connectionString = "Data Source=Martina;Initial Catalog=NORTHWND;Integrated Security=True";
        internal Employees GetEmployee(string queryString, Employees employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employee.ID = int.Parse(reader[0].ToString());
                        employee.LastName = reader[1].ToString();
                        employee.FirstName = reader[2].ToString();                    
                        employee.Title = reader[3].ToString();
                        employee.TitleOfCourtesy = reader[4].ToString();
                        employee.BirthDate = DateTime.Parse(reader[5].ToString());
                        employee.HireDate = DateTime.Parse(reader[6].ToString());
                        employee.Address = reader[7].ToString();
                        employee.City = reader[8].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return employee;
            }
        }

        internal void EditEmployee(Employees employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                try
                {
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@Title", employee.Title);
                    command.Parameters.AddWithValue("@TitleOfCourtesy", employee.TitleOfCourtesy);
                    command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                    command.Parameters.AddWithValue("@HireDate", employee.HireDate);
                    command.Parameters.AddWithValue("@Address", employee.Address);
                    command.Parameters.AddWithValue("@City", employee.City);
                    command.Parameters.AddWithValue("@ID", employee.ID);

                    command.CommandText = @"UPDATE [dbo].[Employees]
                                              SET [LastName] = @LastName
                                                 ,[FirstName] = @FirstName
                                                 ,[Title] = @Title
                                                 ,[TitleOfCourtesy] = @TitleOfCourtesy
                                                 ,[BirthDate] = @BirthDate
                                                 ,[HireDate] = @HireDate
                                                 ,[Address] = @Address
                                                 ,[City] = @City
                                            WHERE [EmployeeID] = @ID";
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}