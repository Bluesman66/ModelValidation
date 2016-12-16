using ModelValidation.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
	[NoVasyaOnMonday]
	public class Appointment
	{
		[Required(ErrorMessage = "Введите свое имя")]
		public string ClientName { get; set; }

		[DataType(DataType.Date)]
		[FutureDate(ErrorMessage = "Введите дату относящуюся к будущему")]
		public DateTime Date { get; set; }
				
		[MustBeTrue(ErrorMessage = "Вы должны принять условия")]
		public bool TermsAccepted { get; set; }
	}
}