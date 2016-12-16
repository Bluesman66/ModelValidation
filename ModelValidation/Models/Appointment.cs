using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
	public class Appointment
	{
		[Required(ErrorMessage = "Введите свое имя")]
		public string ClientName { get; set; }

		[DataType(DataType.Date)]
		[Required(ErrorMessage = "Введите дату")]
		public DateTime Date { get; set; }

		[Range(typeof(bool), "true", "true", ErrorMessage = "Вы должны принять условия")]
		public bool TermsAccepted { get; set; }
	}
}