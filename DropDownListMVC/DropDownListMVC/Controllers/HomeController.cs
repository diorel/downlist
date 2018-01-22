using DropDownListMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DropDownListMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            UsersData obj = new UsersData();
            return View(obj);
        }

         [HttpPost]
         [AllowAnonymous]
         public async Task<ActionResult> Index(UsersData obj)
         {
            int d = obj.id;
            Response.Write(d);
            return View("Index",obj);

        }



    }
}