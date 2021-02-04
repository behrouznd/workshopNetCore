using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Workshop2.Interfaces;
using Workshop2.Models;

namespace Workshop2.Controllers
{
    public class StudentController : Controller
    {
        
         
        IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepo )
        {
            this.studentRepository = studentRepo;

     

        }
        public IActionResult Index()
        {
            IEnumerable<Student> students = studentRepository.GetAllStudents();

            return View(students);
        }

        public IActionResult Edit(int id)
        {
            Student student = studentRepository.SearchStudent(x => x.ID == id).FirstOrDefault();
            return View(student);

        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            studentRepository.updateStudent(student);
            return RedirectToAction("Index");



        }

        public IActionResult Create()
        {
            return View();

        }

        public IActionResult Delete(int id)
        {
            studentRepository.DeleteStudent(id);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Add(Student  student)
        {
            studentRepository.CreateStudent(student);
            return RedirectToAction("Index");

        }
    }
}