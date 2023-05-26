using System;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_intro.Controllers
{
	public class UserController:Controller
	{
		public ActionResult Index()
		{
			@ViewBag.Name = "Shamil";
			@ViewBag.Surname = "Huseynov";
			@ViewBag.Age = 19;
			@ViewBag.Country = "Azerbaijan";
			ViewBag.PhoneNumber = 0505049639;

            return View();
		}
	}
}

