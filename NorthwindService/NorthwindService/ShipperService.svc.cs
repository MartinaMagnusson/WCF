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

            Shipper shipper = new Shipper();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", ID);

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
        public void SaveShipper(Shipper shipper)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdpater = new SqlDataAdapter(@"SELECT [ShipperID],[CompanyName],[Phone] 
                                                                    FROM[NORTHWND].[dbo].[Shippers] 
                                                                    WHERE[ShipperID] =" + shipper.ID, connection);

                dataAdpater.UpdateCommand = new SqlCommand(@"UPDATE [dbo].[Shippers]
                                                            SET [CompanyName] = " + shipper.CompanyName +
                                                           ",[Phone] = " + shipper.Phone +
                                                            "WHERE [ShipperID] = " + shipper.ID, connection);

                //dataAdpater.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 15, shipper.ID);
                //dataAdpater.UpdateCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 15, shipper.CompanyName);
                //dataAdpater.UpdateCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 15, shipper.Phone);

                SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add("@ShipperID", SqlDbType.Int);
                parameter.SourceColumn = "ShipperID";
                parameter.SourceVersion = DataRowVersion.Original;

                DataTable shipperTable = new DataTable();
                dataAdpater.Fill(shipperTable);

                DataRow shipperID = shipperTable.Rows[0];
                //DataRow shipperCompanyName = shipperTable.Rows[0];
                //DataRow shipperPhone = shipperTable.Rows[2];
                shipperID["ShipperID"] = shipper.ID;
                //shipperCompanyName["CompanyName"] = "CompanyName";
                //shipperPhone["Phone"] = "Phone";

               dataAdpater.Update(shipperTable);

                Console.WriteLine("Rows after update.");
                foreach (DataRow row in shipperTable.Rows)
                {
                    {
                        Console.WriteLine("{0}: {1}", row[0], row[1]);
                    }
                }
            }
        }
    }
}
