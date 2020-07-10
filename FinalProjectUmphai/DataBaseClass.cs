using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FinalProjectUmphai.Models;

namespace FinalProjectUmphai

{
    class DataBaseClass
    {
        public static SqlConnection connect = new SqlConnection("Data Source=DESKTOP-9UEP9UH;Initial Catalog=FinalProject;Integrated Security=True");
        public static SqlCommand cmd;
        public static SqlDataAdapter adapter;
        public static DataSet ds=new DataSet();
        public static DataTable dt = new DataTable();


        public static SqlConnection GetConnet()
        {
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
                Console.WriteLine("Connected");
                return connect;
            }
            else
            {
                connect.Close();
                Console.WriteLine("Connection close");
                return connect;
            }
        }

        public static bool GetLogin(String sql)
        {
            String status;
            try
            {
                cmd = new SqlCommand(sql, connect);
                adapter = new SqlDataAdapter(cmd);
                if (ds.Tables["dsLogin"] != null)
                {
                    ds.Tables["dsLogin"].Clear();
                }
               
                adapter.Fill(ds, "dsLogin");
                if (ds.Tables["dsLogin"].Rows.Count > 0)
                {
                    status = ds.Tables["dsLogin"].Rows[0]["position"].ToString();
                    Console.WriteLine("Login Success");
                    Console.WriteLine("Status:"+status);

                    return true;
                }
                else
                {
                    Console.WriteLine("Login Fail");
                    return false;
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Login Fail:"+ex.Message.ToString());
                return false;
            }
        }
        public static void GetData(String sql,DataGridView dataGridView)
        {
            DataModel dataModel = new DataModel();
            cmd = new SqlCommand(sql,connect);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataModel.ds, "dsUser");
            dataGridView.DataSource = dataModel.ds.Tables["dsUser"];
            dataGridView.Refresh();


        }
        public static bool SearchQuery(string sql)
        {
            cmd = new SqlCommand(sql, connect);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds, "tbSearch");
            if (ds.Tables["tbSearch"] != null)
            {
                ds.Tables["tbSearch"].Clear();
            }
            adapter.Fill(ds, "tbSearch");
            if (ds.Tables["tbSearch"].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InsertQuery(String sql)
        {
            cmd = new SqlCommand(sql, connect);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Added");
                return true;
            }
            else
            {
                Console.WriteLine("Fail");
                return false;
            }
        }
        
    }
}
