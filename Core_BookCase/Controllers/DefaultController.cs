using Core_BookCase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_BookCase.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var book = new List<Books>()
            {
                new Books { Id = 1, BookNAme="Satranç", Author="Zweig"},
                new Books { Id = 2, BookNAme="Dr Ox'un Deneyi", Author="Jules Verne"},
                new Books { Id = 3, BookNAme="Delifişek", Author="Vasconceulos"},
                new Books { Id = 4, BookNAme="Kırmızı Bisiklet", Author="Muzaffer İzgü"},
                new Books { Id = 5, BookNAme="Toros Canavarı", Author="Aziz Nesin"}
            };
            return View(book);
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult StaticTheme()
        {
            return View();
        }
    }
}
