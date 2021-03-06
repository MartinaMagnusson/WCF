﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NorthwindService.Repository
{
    public class NorthwindRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["theDB"].ToString();
        public Shipper GetShipper(string queryString, Shipper shipper)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    shipper.ID = reader[0].ToString();
                    shipper.CompanyName = reader[1].ToString();
                    shipper.Phone = reader[2].ToString();
                }
                reader.Close();

                return shipper;
            }
        }
        public void SaveShopper(Shipper shipper)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();
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
        }
    }
}