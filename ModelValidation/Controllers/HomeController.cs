using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
		public ViewResult MakeBooking()
		{
			return View(new Appointment { Date = DateTime.Now });
		}

		[HttpPost]
		public ViewResult MakeBooking(Appointment appt)
		{
			if (ModelState.IsValid)
			{
				// В реальном приложении здесь находились бы операторы
				// для сохранения нового объекта Appointment в базе данных
				return View("Completed", appt);
			}
			else
				return View();
		}
	}
}