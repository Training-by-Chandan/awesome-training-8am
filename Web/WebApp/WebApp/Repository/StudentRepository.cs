using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Repository
{
    public class StudentRepository
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