using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbIntegration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DB db = new DB();
            db.ReadDataFromStudent();
            Console.ReadLine();
        }
    }

    public class DB
    {
        //data source => server, database => initial catalog
        private string connectionString = "Data Source=DESKTOP-PT71T7O\\SQLCHANDAN;Database=Test;Integrated Security=true;";

        public void ReadDataFromTable(string tableName)
        {
            try
            {
                //step 0: create the query
                string query = $"select * from {tableName}";
                //step 1 : Create the connection object using connectionstring
                SqlConnection con = new SqlConnection(connectionString);
                //step 2: create the sqlcommand object using query and connection object
                SqlCommand cmd = new SqlCommand(query, con);
                //step 3: open the connection
                con.Open();
                //step 4: execute the command
                //select => executereader,: insert, update, delete => executenonquery
                var reader = cmd.ExecuteReader();
                //step 5 : process your data
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var colName = reader.GetName(i);
                        var data = reader.GetValue(i);
                        Console.WriteLine($"{colName} => {data.ToString()}");
                    }
                    Console.WriteLine("\n=================================================================\n");
                }
                //step 6 : Clone the connection
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ReadDataFromTableV2(string tableName)
        {
            DataSet dataSet = new DataSet();
            try
            {
                //step 0: create the query
                string query = $"select * from {tableName}";
                //step 1 : Create the connection object using connectionstring
                SqlConnection con = new SqlConnection(connectionString);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                dataAdapter.Fill(dataSet);
                var tbl = dataSet.Tables[0];
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    for (int j = 0; j < tbl.Columns.Count; j++)
                    {
                        var colName = tbl.Columns[j].ColumnName;
                        var data = tbl.Rows[i][j];
                        Console.WriteLine($"{colName} => {data.ToString()}");
                    }
                    Console.WriteLine("\n=================================================================\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ReadDataFromStudent()
        {
            try
            {
                DataSet dataSet = new DataSet();
                //step 0: create the query
                string query = $"select * from student\nselect * from menu";
                //step 1 : Create the connection object using connectionstring
                SqlConnection con = new SqlConnection(connectionString);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                dataAdapter.Fill(dataSet);
                var tbl = dataSet.Tables[0];
                var tblnew = dataSet.Tables[1];
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    var id = Convert.ToInt32(tbl.Rows[i]["id"]);
                    var name = tbl.Rows[i]["name"].ToString();
                    Console.WriteLine($"{id}. {name}");
                    Console.WriteLine("\n=================================================================\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}