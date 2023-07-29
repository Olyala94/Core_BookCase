using Core_Departman2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Core_Departman2.Controllers
{
    public class PersonelimController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var values = c.Personels.Include(x => x.Birim).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> values = (from x in c.Birims.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.BirimAdi,
                                               Value = x.BirimId.ToString(),
                                           }).ToList();
            ViewBag.dgr = values;
            return View();
        }

        [HttpPost]
        public IActionResult YeniPersonel(Personel personel)
        {
            //İlişkili tablodan gelen , yani  DropDownListesinden getirdiği birimi seçebilmek 
            var values = c.Birims.Where(x=>x.BirimId==personel.Birim.BirimId).FirstOrDefault();
            personel.Birim = values;

            c.Personels.Add(personel);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult PersonelSil(int id)
        {

            var values = c.Personels.Find(id);
            c.Personels.Remove(values);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PersonelGetir(int id)
        {
            //List<SelectListItem> values = (from x in c.Birims.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = x.BirimAdi,
            //                                   Value = x.BirimId.ToString(),
            //                               }).ToList();
            //ViewBag.dgr = values;
            var value = c.Personels.Find(id);
            return View("PersonelGetir", value);
        }

        public IActionResult PersonelGuncelle(Personel personel)
        {
            ////İlişkili tablodan gelen , yani  DropDownListesinden getirdiği birimi seçebilmek 
            //var values = c.Birims.Where(x => x.BirimId == personel.Birim.BirimId).FirstOrDefault();
            //personel.Birim = values;

            var value = c.Personels.Find(personel.PersonelId);
            value.Ad = personel.Ad;
            value.Soyad = personel.Soyad;
            value.Sehir = personel.Sehir;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
