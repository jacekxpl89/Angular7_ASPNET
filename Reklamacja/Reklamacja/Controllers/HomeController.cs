using Reklamacja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reklamacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new Complaint_context())
            {
               
                ctx.SaveChanges();
            }
        

            return View();
        }
    }
}
