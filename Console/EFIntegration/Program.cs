using EFIntegration.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFIntegration
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res = "n";
            do
            {
                Console.WriteLine("Press 1 to read all data\nPress 2 to read specific data\nPress 3 to insert the data\nPress 4 to update the data \nPress 5 to delete the data");
                var choice = Convert.ToInt32(Console.ReadLine());
                DBs db = new DBs();
                switch (choice)
                {
                    case 1:
                        db.ReadDataFromSomeTable();
                        break;

                    case 2:
                        db.ReadDataById();
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

                Console.WriteLine("Do you want to run once more?");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
            Console.ReadLine();
        }
    }

    public class DBs
    {
        private TESTEntities db = new TESTEntities();

        internal void ReadDataById()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.SomeTables.Find(id);
            
            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                Console.WriteLine($"{existing.id}. {existing.fname} {existing.lname} {existing.email}");
                Console.WriteLine("=========================================\n");
            }
        }

        internal void DeleteDatatoSomeTable()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.SomeTables.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                db.SomeTables.Remove(existing);
                db.SaveChanges();
            }
        }

        internal void ReadDataFromSomeTable()
        {
            var data = db.SomeTables.ToList();

            foreach (var item in data)
            {
                Console.WriteLine($"{item.id}. {item.fname} {item.lname} {item.email}");
                Console.WriteLine("=========================================\n");
            }
        }

        internal void UpdateDatatoSomeTable()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.SomeTables.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                Console.WriteLine("Enter the first name");
                existing.fname = Console.ReadLine();
                Console.WriteLine("Enter the last name");
                existing.lname = Console.ReadLine();
                Console.WriteLine("Enter the Email");
                existing.email = Console.ReadLine();

                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void WriteDatatoSomeTable()
        {
            var someTbl = new SomeTable();
            Console.WriteLine("Enter the first name");
            someTbl.fname = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            someTbl.lname = Console.ReadLine();
            Console.WriteLine("Enter the email");
            someTbl.email = Console.ReadLine();

            db.SomeTables.Add(someTbl);
            db.SaveChanges();
        }

        public void LinqJoin()
        {
            var data = (from t in db.Teachers
                        join c in db.Classes
                        on t.ClassId equals c.id
                        select new { TeacherName = t.Name, TeacherId = t.id, Class = c.class1 });
            foreach (var item in data)
            {
                Console.WriteLine($"{item.TeacherId}. {item.TeacherName} {item.Class}");
            }
        }

        public void StudentParent()
        {
            var data = db.vw_studentInfo.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"{item.studentid} {item.Student} {item.FatherName} {item.MotherName}");
            }
        }

        public void CreateStudentParent()
        {
            Console.WriteLine("Enter Student Name");
            var studentName = Console.ReadLine();
            Console.WriteLine("Enter Father Name");
            var fatherName = Console.ReadLine();
            Console.WriteLine("Enter Mother Name");
            var motherName = Console.ReadLine();

            var res=db.SP_CREATE_STUDENT_PARENT(studentName, fatherName, motherName);
        }
    }
}