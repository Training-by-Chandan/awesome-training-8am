using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbIntegration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                using (SqlClientListener listener = new SqlClientListener())
                {
                    Console.WriteLine("Press 1 to read all data\nPress 2 to read specific data\nPress 3 to insert the data\nPress 4 to update the data \nPress 5 to delete the data");
                    var choice = Convert.ToInt32(Console.ReadLine());
                    DB db = new DB();
                    switch (choice)
                    {
                        case 1:
                            db.ReadDataFromSomeTable();
                            break;

                        case 2:
                            break;

                        case 3:
                            db.WriteDatatoSomeTable();
                            break;

                        case 4:
                            db.UpdateDatatoSomeTable();
                            break;

                        case 5:
                            db.DeleteDatatoSomeTable();
                            break;

                        default:
                            break;
                    }
                }

                Console.WriteLine("Do you want to run once more?");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }
    }

    public class SqlClientListener : EventListener
    {
        protected override void OnEventSourceCreated(EventSource eventSource)
        {
            // Only enable events from SqlClientEventSource.
            if (eventSource.Name.Equals("Microsoft.Data.SqlClient.EventSource"))
            {
                // Use EventKeyWord 2 to capture basic application flow events.
                // See the above table for all available keywords.
                EnableEvents(eventSource, EventLevel.Informational, (EventKeywords)2);
            }
        }

        // This callback runs whenever an event is written by SqlClientEventSource.
        // Event data is accessed through the EventWrittenEventArgs parameter.
        protected override void OnEventWritten(EventWrittenEventArgs eventData)
        {
            // Print event data.
            Console.WriteLine(eventData.Payload[0]);
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

        public void ReadDataFromSomeTable()
        {
            try
            {
                DataSet dataSet = new DataSet();
                //step 0: create the query
                string query = $"select * from SomeTable";
                //step 1 : Create the connection object using connectionstring
                SqlConnection con = new SqlConnection(connectionString);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                dataAdapter.Fill(dataSet);
                var tbl = dataSet.Tables[0];
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    var id = Convert.ToInt32(tbl.Rows[i]["id"]);
                    var fname = tbl.Rows[i]["fname"].ToString();
                    var lname = tbl.Rows[i]["lname"].ToString();
                    Console.WriteLine($"{id}. {fname} {lname}");
                    Console.WriteLine("=================================================================\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void WriteDatatoSomeTable()
        {
            try
            {
                Console.WriteLine("Enter the first name");
                var fname = Console.ReadLine();
                Console.WriteLine("Enter the last name");
                var lname = Console.ReadLine();

                //step 0: create the query
                string query = $"insert into sometable (fname, lname) values ('{fname}','{lname}')";
                Execute(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void UpdateDatatoSomeTable()
        {
            try
            {
                Console.WriteLine("Enter the Id");
                var id = Console.ReadLine();
                Console.WriteLine("Enter the first name");
                var fname = Console.ReadLine();
                Console.WriteLine("Enter the last name");
                var lname = Console.ReadLine();

                //step 0: create the query
                string query = $"update sometable set fname='{fname}', lname='{lname}' where id={id}";
                Execute(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void DeleteDatatoSomeTable()
        {
            try
            {
                Console.WriteLine("Enter the Id");
                var id = Console.ReadLine();

                //step 0: create the query
                string query = $"delete from sometable where id={id}";
                Execute(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Execute(string query)
        {
            //step 1 : Create the connection object using connectionstring
            SqlConnection con = new SqlConnection(connectionString);
            //step 2: create the sqlcommand object using query and connection object
            SqlCommand cmd = new SqlCommand(query, con);
            //step 3: open the connection
            con.Open();
            //step 4: execute the command
            //select => executereader,: insert, update, delete => executenonquery
            var result = cmd.ExecuteNonQuery();

            //step 6 : Clone the connection
            con.Close();
        }
    }
}