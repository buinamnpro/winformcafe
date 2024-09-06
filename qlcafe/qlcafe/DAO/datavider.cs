using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlcafe.DAO
{
    public  class datavider
    {
        private static datavider instance; 


        string con = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlcafe;Integrated Security=True;";

        public static datavider Instance 
        { 
            get {  if (instance == null) instance = new datavider();return datavider.Instance; } 
            private set => instance = value;
        }
        private datavider() { }

        public DataTable Executequery(string query, object[ ] parameter =null )
        {
            DataTable data = new DataTable();   
            using (SqlConnection c = new SqlConnection(con)) //ussing de tu giai phong bo nho 
            {
                SqlCommand sqlCommand = new SqlCommand(query, c);
                if ( parameter != null )
                {
                    string[ ] listpara = query .Split(' ' );
                    int i = 0;
                    foreach ( string item in listpara ) { 
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                c.Open();
                sqlDataAdapter.Fill(data);
                c.Close();
            }
            return data;
        }
        public int  Executenonquery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection c = new SqlConnection(con)) //ussing de tu giai phong bo nho 
            {
                c.Open();
                SqlCommand sqlCommand = new SqlCommand(query, c);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }


             
                data= sqlCommand.ExecuteNonQuery();
                
                c.Close();
            }
            return data;
        }
        public object Executesacala(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection c = new SqlConnection(con)) //ussing de tu giai phong bo nho 
            {
                c.Open();
                SqlCommand sqlCommand = new SqlCommand(query, c);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = sqlCommand.ExecuteScalar();

               
                c.Close();
            }
            return data;
        }
    }
}
