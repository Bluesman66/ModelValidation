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
			if (String.IsNullOrEmpty(appt.ClientName))
				ModelState.AddModelError("ClientName", "Введите свое имя");

			if (!ModelState.IsValidField("Date"))
				ModelState.AddModelError("Date", "Введите дату");
			else if (DateTime.Now > appt.Date)
				ModelState.AddModelError("Date", "Введите дату относящуюся к будущему");

			if (!appt.TermsAccepted)
				ModelState.AddModelError("TermsAccepted", "Вы должны принять условия");

			if (ModelState.IsValidField("ClientName") && ModelState.IsValidField("Date")
				&& appt.ClientName == "Вася" && appt.Date.DayOfWeek == DayOfWeek.Monday)
			{
				ModelState.AddModelError("", "Васи в понедельник отдыхают!");
			}

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