using MilSiteCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MilSiteCore.ValadationAttributes
{
	class Location_EnsureCreateLessThanUpdateDateAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var location = validationContext.ObjectInstance as Location;
			if (!location.CreateDateLessThanUpdateDate())
			{
				return new ValidationResult("Update Date must be greater then the Create Date");
			}
			return ValidationResult.Success;
		}
	}
}
