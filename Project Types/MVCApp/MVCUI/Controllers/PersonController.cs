using Microsoft.AspNetCore.Mvc;
using MVCUI.Models;

namespace MVCUI.Controllers
{
    public class PersonController : Controller
    {
        private List<PersonModel> _personList = new();
        public IActionResult Index()
        { 
            return View(_personList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel person)
        {
            try
            {
                string message = $"Hello {person.FirstName} {person.LastName}";
                ViewBag.message = message;
                _personList.Add(person);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
