﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pimp_inc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Our product";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Our contact page.";

			return View();
		}
	}
}