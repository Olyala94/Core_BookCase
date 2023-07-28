using Core_Departman2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_Departman2.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();  
        public IActionResult Index()
        {
            var values = c.Birims.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult YeniBirim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniBirim(Birim b)
        {
            c.Birims.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult BirimSil(int id)
        {
            var dep = c.Birims.Find(id);
            c.Birims.Remove(dep);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BirimGetir(int id)
        {
            var value = c.Birims.Find(id);
            return View("BirimGetir", value);
        }

        public IActionResult BirimGuncelle(Birim d)
        {
            var values = c.Birims.Find(d.BirimId);
            values.BirimAdi = d.BirimAdi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
