using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class StudentService
    {
        private StudentRepository studentRepository = new StudentRepository();

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
    }
}