﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManager.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddBook()
        {
            ViewBag.Message = "Add Book";

            return View();
        }

        public ActionResult BookIndex()
        {
            ViewBag.Message = "Add Book";

            return View();
        }


    }
}