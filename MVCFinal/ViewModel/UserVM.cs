using MVCFinalpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFinalpractice.ViewModel
{
    public class UserVM
    {
        public static bool FilterAuth()
        {
            bool isAuth = false;
            if (HttpContext.Current.Session["User"] != null)
            {
                isAuth = true;
            }
            return isAuth;
        }

        public static bool FilterAdmin()
        {
            bool isAdmin = false;
            var oUser = HttpContext.Current.Session["User"] == null ? new User() : (User)HttpContext.Current.Session["User"];
            if (oUser.DepartmentId == 1)
            {
                isAdmin = true;
            }
            return isAdmin;
        }
    }
}