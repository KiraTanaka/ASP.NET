using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using ASP.NET.Models;namespace ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HomeModel model) 
        {
            string result = "";
            switch(model.Action)
            {
                case "+": result = (model.Num1 + model.Num2).ToString();
                    break;
            }
            int home = 5;
            ViewBag.Home = home;
            ViewBag.Result = result;
            return View();
        }

    }
}
