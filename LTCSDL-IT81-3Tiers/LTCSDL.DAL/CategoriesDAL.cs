using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using LTCSDL.DAL.DTO;

namespace LTCSDL.DAL
{
    public class CategoriesDAL
    {
        SqlConnection cnn;

        public CategoriesDAL()
        {
            string cnstr = "Server=DESKTOP-3VODAHR\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            this.cnn = new SqlConnection(cnstr);
        }

        public void selectAll(out string msg)
        {
            msg = "";
            StringBuilder sb = new StringBuilder("Select * from Categories");
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine($"CategoryID: {sdr["CategoryID"]}, CategoryName: {sdr["CategoryName"]}, " +
                        $"Description: {sdr["Description"]}");
                }
                cnn.Close();
                msg = "Select successfully !!!";
            }
            catch (SqlException ex)
            {
                msg = "OOPs, something went wrong.\n" + ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public int delete(int id, out string msg)
        {
            msg = "";
            int res = 0;
            StringBuilder sb = new StringBuilder($"Delete from  Categories Where CategoryID = {id} SELECT @@IDENTITY as [CateID]");
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    res = int.Parse(sdr["CateID"].ToString());
                }
                cnn.Close();
                msg = "Delete successfully !!!";
            }
            catch (SqlException ex)
            {
                msg = "OOPs, something went wrong.\n" + ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return res;
        }

        public int update(int id, string name, out string msg)
        {
            msg = "";
            int res = 0;
            StringBuilder sb = new StringBuilder($"Update Categories Set CategoryName = {name} Where CategoryID = {id} SELECT @@IDENTITY as [CateID]");
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    res = int.Parse(sdr["CateID"].ToString());
                }
                cnn.Close();
                msg = "Update successfully !!!";
            }
            catch (SqlException ex)
            {
                msg = "OOPs, something went wrong.\n" + ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return res;
        }

        public int insert(string name, string description, out string msg)
        {
            msg = "";
            int res = 0;
            //string sql = "Insert Into Categories(CategoryName, [Description])";
            //sql = sql + " Values('"+ name + "', '"+ description + "')";
            StringBuilder sb = new StringBuilder("Insert Into Categories(CategoryName, [Description]) ");
            sb.AppendFormat("Values('{0}', '{1}');", name, description);
            sb.Append("SELECT @@IDENTITY as [CateID]");
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    res = int.Parse(sdr["CateID"].ToString());
                }
                cnn.Close();
                msg = "Insert successfully !!!";
            }
            catch (SqlException ex)
            {
                msg = "OOPs, something went wrong.\n" + ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return res;
        }

        public CategoriesDTO getCategoryById(int id, out string msg)
        {
            msg = "";
            CategoriesDTO res = new CategoriesDTO();
            StringBuilder sb = new StringBuilder("SELECT * FROM Categories ");
            sb.AppendFormat("WHERE CategoryID={0}", id.ToString());
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = sb.ToString();
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    res.CategoryID = int.Parse(sdr["CategoryID"].ToString());
                    res.CategoryName = sdr["CategoryName"].ToString();
                    res.Description = sdr["Description"].ToString();
                }
                cnn.Close();
            }
            catch (SqlException ex)
            {
                msg = "OOPs, something went wrong.\n" + ex.Message;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return res;
        }
    }
}
