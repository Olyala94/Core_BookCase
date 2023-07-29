using Core_Departman2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography.Xml;

namespace Core_Departman2.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        public async Task<IActionResult> SignIn(Admin p)
        {
            var values = context.Admins.FirstOrDefault(x => x.UserName == p.UserName && x.Password == x.Password);

            //// Eğer eşleşen bir kayıt bulunursa buradaki işlemleri yapabilirsiniz.
            if (values != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, p.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personelim");
            }
            return View();
        }
    }
}

