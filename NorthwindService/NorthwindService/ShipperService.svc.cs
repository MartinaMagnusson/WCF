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
        string connectionString = "Data Source=Martina;Initial Catalog=NORTHWND;Integrated Security=True";

        public Shipper GetShipper(string ID)
        {
            string queryString = @"SELECT [ShipperID],[CompanyName],[Phone] 
                                   FROM[NORTHWND].[dbo].[Shippers] 
                                   WHERE[ShipperID] = @ID";

            var shipper = new Shipper();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", shipper.ID);

                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
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
        public void SaveShipper(Shipper shipper)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
                try
                {
                    command.Parameters.AddWithValue("@CompanyName", shipper.CompanyName);
                    command.Parameters.AddWithValue("@Phone", shipper.Phone);
                    command.Parameters.AddWithValue("@ID", shipper.ID);

                    command.CommandText = @"UPDATE [dbo].[Shippers]
                                        SET [CompanyName] = @CompanyName ,
                                        [Phone] = @Phone
                                        WHERE [ShipperID] = @ID";
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
