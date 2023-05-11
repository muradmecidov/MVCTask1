using Microsoft.AspNetCore.Mvc;
using WebTask1.Models;

namespace WebTask1.Controllers
{
    public class TeacherController : Controller
    {
        public List<Teacher> Teachers = new List<Teacher>()
        {
        new Teacher{Id=1,Name="Nermin",Salary=3500},
        new Teacher{Id=1,Name="Zahid",Salary=5500},
        new Teacher{Id=1,Name="Allahverdi",Salary=4500},
        new Teacher{Id=1,Name="Nergiz",Salary=1500},
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
