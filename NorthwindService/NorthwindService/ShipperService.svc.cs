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
        string connectionString =
             "Data Source=Martina;Initial Catalog=NORTHWND;Integrated Security=True";
        public Shipper GetShipper(string ID)
        {
            string queryString = @"SELECT [ShipperID],[CompanyName],[Phone] 
                                   FROM[NORTHWND].[dbo].[Shippers] 
                                   WHERE[ShipperID] =" + ID;

            int paramValue = 5;
            Shipper shipper = new Shipper();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        shipper.ID = reader[0].ToString();
                        shipper.CompanyName = reader[1].ToString();
                        shipper.Phone = reader[2].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return shipper;
            }
        }
        public void SaveShipper(string ID, string companyName, string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(@"SELECT [ShipperID],[CompanyName],[Phone] 
                                                                    FROM[NORTHWND].[dbo].[Shippers] 
                                                                    WHERE[ShipperID] =" + ID, connection);

                dataAdpater.UpdateCommand = new SqlCommand(@"UPDATE [dbo].[Shippers]
                                                            SET [CompanyName] = @CompanyName
                                                           ,[Phone] = @Phone
                                                            [ShipperID] = @ID");

                dataAdpater.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 15, ID);
                dataAdpater.UpdateCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 15, companyName);
                dataAdpater.UpdateCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 15, phone);

                //SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
                //  "@ID", SqlDbType.Int);
                //parameter.SourceColumn = "ShipperID";
                //parameter.SourceVersion = DataRowVersion.Original;

                DataTable categoryTable = new DataTable();
                dataAdpater.Fill(categoryTable);

                //DataRow categoryRow = categoryTable.Rows[0];
                //categoryRow["ShipperID"] = "New Beverages";

                dataAdpater.Update(categoryTable);

                //Console.WriteLine("Rows after update.");
                //foreach (DataRow row in categoryTable.Rows)
                //{
                //    {
                //        Console.WriteLine("{0}: {1}", row[0], row[1]);
                //    }
                //}
            }
        }
    }
}
