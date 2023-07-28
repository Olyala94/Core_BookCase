using Core_Departman.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Departman.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            var values = c.Personels.ToList();
            return View(values);
        }
    }
}
