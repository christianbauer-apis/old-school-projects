using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WindowsFormsApplication5
{
    class SaleDBConnect
    {
        public SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        string connectionString = ConfigurationManager.ConnectionStrings["Sales"].ToString();
        public string LastError { get; set; }
        public SqlConnection GetConnection()
        {
            if (con == null)
                con = new SqlConnection(connectionString);
            return con;
        }

        public int InsertSale(Sale s)
        {
            con = new SqlConnection(connectionString);
            cmd.Connection = con;
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "saleinsert";
            cmd.Parameters.AddWithValue("@SalesID", s.SalesID);
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@Flooring", s.Flooring);
            cmd.Parameters.AddWithValue("@Charge", s.Charge);
            cmd.Parameters.AddWithValue("@Installation", s.Installation);
            cmd.Parameters.AddWithValue("@Area", s.Area);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }

        public void DeleteSale(Sale s) 
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd.Connection = con;
                con.Open();
                SqlCommand cmd1 = new SqlCommand("delete from SalesTable where SalesID=@SalesID", con);
                cmd1.Parameters.AddWithValue("@SalesID", s.SalesID);

                cmd1.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                LastError = ex.Message;

            }

        }

        public void UpdateSale(Sale s)
        {
            try
            {
                con = new SqlConnection(connectionString);

                string select = "Update SalesTable Set SalesID = @SalesID, Name =  @Name,  Area =  @Area, Charge = @Charge, Flooring =  @Flooring, Installation =  @Installation where SalesID = @SalesID";
                SqlCommand cmd = new SqlCommand(select, con);

                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@SalesID", s.SalesID);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Flooring", s.Flooring);
                cmd.Parameters.AddWithValue("@Charge", s.Charge);
                cmd.Parameters.AddWithValue("@Installation", s.Installation);
                cmd.Parameters.AddWithValue("@Area", s.Area);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            
            catch (Exception ex)
            {
                LastError = ex.Message;
                
            }
        }

        // trying to fill textboxes but not working
        //public string Autofiller(Sale s) 
        //{
            
        //    con = new SqlConnection(connectionString);
        //     con.Open();
        //     SqlCommand cmd2 = new SqlCommand("select * from SalesTable where SalesID=@SalesID", con);
        //     cmd2.Parameters.AddWithValue("@SalesID", s.SalesID);
        //     DataTable table = new DataTable();
        //     SqlDataReader dr = cmd2.ExecuteReader();
        //     table.Load(dr);
        //     return " " + s.Name;
        //     dr.Close();
        //    // cmd2.ExecuteNonQuery();
        //     con.Close();
             
        //}

        public DataTable GetSales()
        {

            try
            {
                string sqlString = "SELECT * FROM SalesTable";
               

                DataSet salesDS = new DataSet();
                salesDS = GetDataSet(sqlString);
                return salesDS.Tables[0];
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return null;
            }


        }
        public void Open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void Close()
        {
            con.Close();
        }

        public SqlDataReader GetReader(string procnameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {


            SqlCommand cmd = new SqlCommand(procnameOrQuery, this.GetConnection());
            cmd.CommandType = cmdType;


            if (param1 != null)
                cmd.Parameters.Add(param1);
            if (param2 != null)
                cmd.Parameters.Add(param2);
            if (param3 != null)
                cmd.Parameters.Add(param3);
            if (param4 != null)
                cmd.Parameters.Add(param4);

            try
            {
                this.Open();
                return cmd.ExecuteReader();

            }
            finally
            {
                cmd.Dispose();
            }

        }

        public DataTable GetTable(string procnameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {

            DataTable table = new DataTable();
            SqlDataReader reader = null;

            try
            {
                reader = GetReader(procnameOrQuery, cmdType, param1, param2, param3, param4);
                table.Load(reader);
                reader.Close();
                return table;
            }
            finally
            {
                this.Close();
            }
        }

       


        public int ExecuteNonQuery(string procnameOrQuery, CommandType cmdType, SqlParameter param1 = null, SqlParameter param2 = null, SqlParameter param3 = null, SqlParameter param4 = null)
        {
            SqlCommand cmd = new SqlCommand(procnameOrQuery, this.GetConnection());
            cmd.CommandType = cmdType;

            if (param1 != null)
                cmd.Parameters.Add(param1);
            if (param2 != null)
                cmd.Parameters.Add(param2);
            if (param3 != null)
                cmd.Parameters.Add(param3);
            if (param4 != null)
                cmd.Parameters.Add(param4);

            try
            {
                this.Open();
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                this.Close();
                cmd.Dispose();
            }
        }

        public DataSet GetDataSet(string sql)
        {
            DataSet aDataset = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, this.GetConnection());
                this.Open();
                adapter.Fill(aDataset);
                return aDataset;
            }
            finally
            {
                this.Close();
            }
        }

    }
}