using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Controller]
    [Route("[Controller]")]
    public class StudentController : Controller
    {
        private readonly StudentServices studentServices;
        public StudentController(StudentServices studentServices)
        {
            this.studentServices = studentServices;
        }

        [HttpGet]
        public IEnumerable<ProjectStudent> GetAllStudent()
        {
            return studentServices.GetAllStudent();
        }

        [HttpGet]
        [Route("{id}")]
        public ProjectStudent GetAllStudent(int id)
        {
            return studentServices.GetStudentByEmail(id);
        }
    }
}
