﻿using System.Web.Mvc;

namespace AHAS.PO.UI.SITE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Theme = "gray-theme";
            return View();
        }
    }
}