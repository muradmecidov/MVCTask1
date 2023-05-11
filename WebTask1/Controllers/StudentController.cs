using Microsoft.AspNetCore.Mvc;
using WebTask1.Models;

namespace WebTask1.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> Students = new List<Student>()
        {
        new Student{Id=1,Name="Murad",Surname="Mecidov",Age=21},
        new Student{Id=2,Name="Ali",Surname="Novruzov",Age=21},
        new Student{Id=3,Name="Elsad",Surname="Yagoubov",Age=21},
        new Student{Id=4,Name="Orxan",Surname="Orucov",Age=21},

        };

        public IActionResult Index()
        {
            return View();
        }
    }
}
