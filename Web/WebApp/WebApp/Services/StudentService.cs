using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public interface IStudentService
    {
        bool Create(StudentViewModel model);

        bool Edit(StudentViewModel model);

        List<StudentViewModel> GetAll();

        StudentViewModel GetById(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService()
        {
            studentRepository = new StudentRepository();
        }

        public List<StudentViewModel> GetAll()
        {
            try
            {
                var data = studentRepository.GetAll().Select(p => new StudentViewModel()
                {
                    Email = p.Email,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Id = p.Id,
                    PhoneNumber = p.PhoneNumber
                });
                return data.ToList();
            }
            catch (Exception ex)
            {
                return new List<StudentViewModel>();
            }
        }

        public bool Create(StudentViewModel model)
        {
            try
            {
                var student = new Student()
                {
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber
                };
                return studentRepository.Create(student);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public StudentViewModel GetById(int id)
        {
            var data = studentRepository.GetbyId(id);
            if (data == null) return null;
            else
            {
                var ret = new StudentViewModel()
                {
                    Id = data.Id,
                    FirstName = data.FirstName,
                    LastName = data.LastName,
                    Email = data.Email,
                    PhoneNumber = data.PhoneNumber
                };
                return ret;
            }
        }

        public bool Edit(StudentViewModel model)
        {
            try
            {
                var existing = studentRepository.GetbyId(model.Id);
                if (existing == null) return false;
                else
                {
                    existing.FirstName = model.FirstName;
                    existing.LastName = model.LastName;
                    existing.Email = model.Email;
                    existing.PhoneNumber = model.PhoneNumber;
                    return studentRepository.Edit(existing);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}