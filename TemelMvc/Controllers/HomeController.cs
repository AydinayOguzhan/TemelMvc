using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemelMvc.Models;

namespace TemelMvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new Book());
        }

        public ActionResult Detail()
        {
            string description = "Bu bir açıklamadır......!";

            return View(model: description);
        }
    }
}