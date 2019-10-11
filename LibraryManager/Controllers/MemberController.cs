using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManager.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult MemberIndex()
        {
            return View();
        }




        public ActionResult AddMember()
        {
            return View();
        }
    }
}