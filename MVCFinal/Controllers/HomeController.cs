using MVCFinalpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFinalpractice.Controllers
{
	public class HomeController : Controller
	{
		UserControl1Entities Db = new UserControl1Entities();
		public ActionResult Index()
		{
			return View();
		}
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {

            var oUser = Db.Users.Where(w => w.Username == user.Username && w.Password == user.Password).FirstOrDefault();
            if (oUser != null)
            {
                Session["User"] = oUser;
                return RedirectToAction("Index", "Users");
            }

            return View();
        }
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Home");
        }

    }
}