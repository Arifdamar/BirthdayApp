using BirthdayApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InvitationForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InvitationForm(InvitationModel model)
        {
            if (ModelState.IsValid)
            {
                DataBase.Add(model);
                return View("Thanks", model);
            }

            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Attendants()
        {
            var attendants = DataBase.List.Where(i => i.AttendanceStatus == true);

            return PartialView(attendants);
        }
    }
}