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
			return RedirectToAction("Index");
		}

		public IActionResult DepartDelete(int id)
		{
			var dep = c.Departmans.Find(id);
			c.Departmans.Remove(dep);
			c.SaveChanges();
			return RedirectToAction("Index");
		}

        public IActionResult DepartmanGetir(int id)
        {
			var depart = c.Departmans.Find(id);
			return View("DepartmanGetir", depart);
        }

		public IActionResult DepartmanGuncelle(Departman d)
		{
			var values = c.Departmans.Find(d.Id);
			values.DepartmanAdi = d.DepartmanAdi;
			c.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
