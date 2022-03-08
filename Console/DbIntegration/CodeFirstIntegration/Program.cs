using CodeFirstIntegration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstIntegration
{
    internal class Program
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
        private ConsoleContext db = new ConsoleContext();

        internal void ReadDataById()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);

            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                Console.WriteLine($"{existing.id}. {existing.Name} {existing.Email} {existing.PhoneNumber}");
                Console.WriteLine("=========================================\n");
            }
        }

        internal void DeleteDatatoSomeTable()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                db.Students.Remove(existing);
                db.SaveChanges();
            }
        }

        internal void ReadDataFromSomeTable()
        {
            var data = db.Students.ToList();

            foreach (var item in data)
            {
                Console.WriteLine($"{item.id}. {item.Name} {item.Email} {item.PhoneNumber}");
                Console.WriteLine("=========================================\n");
            }
        }

        internal void UpdateDatatoSomeTable()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing == null)
            {
                Console.WriteLine("Record Not found");
            }
            else
            {
                Console.WriteLine("Enter the Name");
                existing.Name = Console.ReadLine();
                Console.WriteLine("Enter the Email");
                existing.Email = Console.ReadLine();
                Console.WriteLine("Enter the Phone Number");
                existing.PhoneNumber = Console.ReadLine();

                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void WriteDatatoSomeTable()
        {
            var someTbl = new Student();
            Console.WriteLine("Enter the name");
            someTbl.Name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            someTbl.Email = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            someTbl.PhoneNumber = Console.ReadLine();

            db.Students.Add(someTbl);
            db.SaveChanges();
        }
    }
}