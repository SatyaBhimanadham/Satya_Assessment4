using AssesmentOnEF.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AssesmentOnEF.Controllers
{
    public class StudentController : Controller
    {
        private readonly Asses3Context objstudent;
        public StudentController()
        {
            objstudent = new Asses3Context();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var student = objstudent.Students;
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                objstudent.Students.Add(student);
                objstudent.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var student = objstudent.Students.Single(s => s.StudentId == id);
            return View(student);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = objstudent.Students.Single(s => s.StudentId == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                objstudent.Students.Update(student);
                objstudent.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = objstudent.Students.Single(s => s.StudentId == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            objstudent.Students.Remove(student);
            objstudent.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}
