using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;

namespace WareHouseProject.WebApp.Controllers
{
    public class AuthController : Controller
    {
        SiteProvider provider;
        public AuthController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Failed()
        {
            return View();
        }
        [Authorize]
        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            Response.Cookies.Delete("CartKey", new CookieOptions { Path="/"});
            return Redirect("/");
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel obj, string returnUrl = null)
        {
            //User.FindFirstValue()
            Account account = provider.Account.SignIn(obj);
            if (account != null)
            {
                List<Claim> claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,account.LastName),
                        new Claim(ClaimTypes.Role,account.Position),
                        new Claim(ClaimTypes.SerialNumber,account.CodeUser),
                        new Claim(ClaimTypes.NameIdentifier,account.AccountKey.ToString()),
                        new Claim(ClaimTypes.CookiePath,account.CartKey.ToString()),
                        new Claim(ClaimTypes.Actor,(account.CustomerFlag!= true?"0":"1")),
                    };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
                AuthenticationProperties properties = new AuthenticationProperties
                {
                    IsPersistent = true
                };
                await HttpContext.SignInAsync(principal, properties);
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return Redirect("/");
            }
            ModelState.AddModelError(string.Empty, "Sign In Failed");
            return View(obj);
        }
        public IActionResult Register()
        {
            ViewBag.provinces = new SelectList(provider.Province.GetProvinces(),"ProvinceID","ProvinceName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(Account obj, IFormFile f)
        {
            //ViewBag.provinces = new SelectList(provider.Province.GetProvinces(), "ProvinceID", "ProvinceName");
            if (f != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    f.CopyTo(ms);
                    byte[] bytes = ms.ToArray();
                    obj.Image = bytes;
                }
            }
            int ret = provider.Account.Register(obj);
            if (ret > 0)
            {
                return Redirect("/auth/success");
            }
            return Redirect("/auth/failed");
        }
         public IActionResult Ajax()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ajax(IFormFile f)
        {
            string path = Directory.GetCurrentDirectory();
            using (MemoryStream ms = new MemoryStream())
            {
                f.CopyTo(ms);
                byte[] bytes = ms.ToArray();
                provider.Photo.UpadateImage(bytes);
                return Json( new { Img = bytes });
            }
        }
        public IActionResult Districts(string id)
        {
             return Json(provider.District.GetDistricts(id));
        }
        public IActionResult Wards(string id)
        {
            return Json(provider.Ward.GetWards(id));
        }

    }
}
