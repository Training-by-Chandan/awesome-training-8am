using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormApp.Context;
using WinFormApp.Model;

namespace WinFormApp.Services
{
    public class StudentService
    {
        private CurrentContext db = new CurrentContext();

        public List<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public bool Create(Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Student> GetAllWithoutEF()
        {
            try
            {
                List<Student> Students = new List<Student>();
                //step 0: create the query
                string query = $"select * from StudentInfo";
                //step 1 : Create the connection object using connectionstring
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
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
                    Student student = new Student();
                    student.Id=Convert.ToInt32(reader["Id"]);
                    student.FirstName = reader["FName"].ToString();
                    student.LastName = reader["LName"].ToString();
                    student.Email = reader["Email"].ToString();
                    Students.Add(student);
                    
                }
                //step 6 : Clone the connection
                con.Close();
                return Students;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Student>();
            }
        }
    }
}