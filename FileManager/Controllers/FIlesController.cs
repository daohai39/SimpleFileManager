using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileManager.Controllers
{
    public class FIlesController : Controller
    {
        // GET: FIles
        public ActionResult Index()
        {
            return View();
        }
    }
}