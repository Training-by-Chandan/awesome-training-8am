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

        bool Edit(Student model);

        IQueryable<Student> GetAll();

        Student GetbyId(int id);
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

        public Student GetbyId(int id)
        {
            return db.Students.Find(id);
        }

        public bool Edit(Student model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
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