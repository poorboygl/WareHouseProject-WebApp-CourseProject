using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouseProject.WebApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace WareHouseProject.WebApp.Controllers
{
    public class CartController : Controller
    {
        SiteProvider provider;
        public CartController(SiteProvider provider)
        {
            this.provider = provider;
        }
        public IActionResult Delete(int id)
        {


                Guid cartKey = Guid.Parse(Request.Cookies["CartKey"]);
                provider.Cart.Delete(cartKey, id);
            return Redirect("/cart");
        }
        public IActionResult Edit(Cart obj)
        {

      
                obj.CartKey= Guid.Parse(Request.Cookies["CartKey"]);
                provider.Cart.Update(obj);
            return Redirect("/cart");
        }
        public IActionResult Index()
        {
            Guid cartkey = new Guid();
            cartkey = CheckedCookie(cartkey);
                
                string accountKey = User.FindFirstValue(ClaimTypes.NameIdentifier);
                int? id = null;
                if (!string.IsNullOrEmpty(accountKey))
                {
                    id = int.Parse(accountKey);
                }
                List<Cart> list = provider.Cart.GetCarts(cartkey, id);
                return View(list);
        }
        //[Authorize]
        [HttpPost] 
        public IActionResult Add(Cart obj)
        {
          
            obj.CartKey=CheckedCookie(obj.CartKey);         
            string AccountKey = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //if (!string.IsNullOrEmpty(AccountKey))
            //{
            //    obj.AccountKey = int.Parse(AccountKey);
            //}
            obj.AccountKey = int.Parse(AccountKey);
            provider.Cart.AddCart(obj);
            return Redirect("/cart");

        }
        public Guid CheckedCookie(Guid key)
        {

            if (Request.Cookies["CartKey"] is null)
            {
                CookieOptions option = new CookieOptions
                {
                    Path = "/",
                    Expires = DateTime.UtcNow.AddDays(15)
                };
                if (User.FindFirstValue(ClaimTypes.CookiePath) == "")
                {
                    key = Guid.NewGuid();
                }
                else
                {
                    key = Guid.Parse(User.FindFirstValue(ClaimTypes.CookiePath));
                }
                Response.Cookies.Append("CartKey", key.ToString(), option);
            }

            else
            {
                key = Guid.Parse(Request.Cookies["CartKey"]);
            }
            return key;
        }
    }
}
