using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StdMgtSystem.Models;
using System.Diagnostics;

namespace StdMgtSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
         public IActionResult Index()
        {
            var students = _studentRepository.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = _studentRepository.GetStudent(id);
            return View(student);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Students student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Students newstd = new Students
                    {
                        Name = student.Name,
                        Branch = student.Branch,
                        Section = student.Section
                    };

                    _studentRepository.Add(newstd);
                    return RedirectToAction("Details", new { id = newstd.StudentId });
                }

                // Log ModelState errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    // Log or handle the error as needed
                }

                return View();
            }
            catch (Exception ex)
            {
                // Log the exception
                return RedirectToAction("Error"); // Redirect to an error page or handle it accordingly
            }
        }


        [HttpPost]
        public RedirectToActionResult Delete(int id)
        {
            _studentRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
