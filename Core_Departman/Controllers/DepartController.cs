using Core_Departman.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Departman.Controllers
{
	public class DepartController : Controller
	{
		Context c = new Context();

		public IActionResult Index()
		{
			var degerler = c.Departmans.ToList();
			return View(degerler);
		}

		[HttpGet]
		public IActionResult NewDepartman()
		{
			return View();
		}

		[HttpPost]
		public IActionResult NewDepartman(Departman d)
		{
			c.Departmans.Add(d);
			c.SaveChanges();
			return RedirectToAction("Index", "Depart");
		}

		public IActionResult DepartDelete(int id)
		{
			var dep = c.Departmans.Find(id);
			c.Departmans.Remove(dep);
			c.SaveChanges();
			return RedirectToAction("Index");
		}
		
	}
}
