using System;
using System.Data;
using System.Data.SqlClient;

namespace LTCSDL_Console_IT02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /// Tao COnnection
            string cnstr = "Server=DESKTOP-3VODAHR\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection cnn = new SqlConnection(cnstr);

            // Taso command
            /*string sql = "select c.CustomerID, c.CompanyName, o.OrderID, o.OrderDate, o.ShipAddress " +
                         "from Customers c, Orders o " +
                         "where c.CustomerID = o.CustomerID and c.CustomerID = N'VINET'"; */
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "CustOrdersOrders";
            cmd.CommandType = CommandType.StoredProcedure;

            /*SqlParameter orderID = new SqlParameter("@OrderID", SqlDbType.Int);
            orderID.Value = 10248;

            cmd.Parameters.Add(orderID);*/

            SqlParameter customerID = new SqlParameter("@CustomerID", SqlDbType.NChar);
            customerID.Value = "VINET";

            cmd.Parameters.Add(customerID);

            // Mo ket noi
            try
            {
                cnn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();


                while (sdr.Read())
                {
                    Console.WriteLine($"OrderID: {sdr["OrderID"]}, OrderDate: {sdr["OrderDate"]}, " +
                        $"RequiredDate: {sdr["RequiredDate"]}, ShippedDate: {sdr["ShippedDate"]}");
                }

                // Dong ket noi
                cnn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }
    }
}