using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IStudentRepository
    {
        bool Create(Student student);

        IQueryable<Student> GetAll();
    }

    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IQueryable<Student> GetAll()
        {
            return db.Students;
        }

        public bool Create(Student student)
        {
            try
            {
                db.Students.Add(student);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}