using CoffwshopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;


namespace CoffwshopMVC.Repository
{
    public class ReservationTable
    {
        public readonly string connectionString;


        public ReservationTable()
        {

            connectionString = @"Data Source = DESKTOP-Q3JLMJE\SQLEXPRESS; Initial Catalog = Coffeshopsite; Integrated Security = True";
        }

        
        public void InsertPersonalData(ReservationModel table)
        {
            try
            {

                SqlConnection connectionObject = new SqlConnection(connectionString);

                connectionObject.Open();
                connectionObject.Execute($"exec Insertreservationtable '{table.Name}', '{table.Email}','{table.Date}','{table.Time}','{table.Person}' ");


                connectionObject.Close();

            }
            catch (SqlException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ReservationModel> Select()

        {
            try
            {
                List<ReservationModel> ListofPersonalData = new List<ReservationModel>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                ListofPersonalData = connection.Query<ReservationModel>("exec Selectreservationtable", connectionString).ToList();
                connection.Close();



                return ListofPersonalData;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
