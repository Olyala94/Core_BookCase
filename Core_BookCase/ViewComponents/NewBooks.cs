using Core_BookCase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_BookCase.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var booklist = new List<Books>()
            {
                new Books
                {
                    Id = 6,
                    BookNAme = "Korku",
                    Author="Zweig"
                },

                new Books
                {
                    Id=7,
                    BookNAme="Anna Karanina",
                    Author="Tolstoy"
                }
            };
            return View(booklist);
        }
    }
}
