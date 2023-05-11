using Microsoft.AspNetCore.Mvc;
using WebTask1.Models;

namespace WebTask1.Controllers
{
    public class GroupController : Controller
    {
        public List<Group> groups = new List<Group>()
        {
            new Group{ Id = 1,Name="109A3"},
             new Group{Id = 2,Name="109A4"},
             new Group{Id = 3,Name="AB201"}

        };


        public IActionResult Index()
        {
            return View();
        }
    }
}
