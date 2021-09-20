using MilSiteCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MilSiteCore.ValadationAttributes
{
	class Location_NumSpaceGreaterThanZero : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			var location = validationContext.ObjectInstance as Location;
			if (!location.NumSpaceGreaterThanZero())
			{
				return new ValidationResult("The number of spaces must be greater than zero");
			}
			return ValidationResult.Success;
		}
	}
}
