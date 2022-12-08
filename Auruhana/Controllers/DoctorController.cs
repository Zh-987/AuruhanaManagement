using Auruhana.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auruhana.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Doctors()
        {
            AuruhanaContext doctorContext = new AuruhanaContext();
            var model = new List<Doctor>();
            model = doctorContext.Doctors.ToList();
            return View(model);
        }
    }
}