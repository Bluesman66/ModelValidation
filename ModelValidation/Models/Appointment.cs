﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ModelValidation.Models
{
	public class Appointment
	{
		public string ClientName { get; set; }

		[DataType(DataType.Date)]
		public DateTime Date { get; set; }

		public bool TermsAccepted { get; set; }
	}
}