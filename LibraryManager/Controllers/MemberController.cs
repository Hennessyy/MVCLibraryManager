using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.MemberProcessor;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMember(Models.Member Model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreateMember(Model.MemberId, Model.FirstName, Model.LastName, Model.TelNo, Model.Email, Model.Pcode);
                return RedirectToAction("AddMember");
            }

            return View();
        }
    }
}