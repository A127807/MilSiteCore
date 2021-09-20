using MilSiteCore.ValadationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MilSiteCore.Models
{
	public class Location
	{
		public int LocId { get; set; }

		[Required]
		[StringLength(200)]
		public string LocName { get; set; }

		public string LocDescription { get; set; }

		[Location_EnsureMaxStayGreaterThanZero]
		public int? MaxStay { get; set; }

		[Required]
		[Location_NumSpaceGreaterThanZero]
		public int? NumSpaces { get; set; }

		[Required]
		public DateTime? DateCreated { get; set; }

		[Location_EnsureCreateLessThanUpdateDate]
		public DateTime? DateUpdated { get; set; }
		//public List<LocationType> LocationsTypes { get; set; }


		public bool ValidateDescription()
		{
			return !string.IsNullOrWhiteSpace(LocDescription);
		}
		public bool CreateDateLessThanUpdateDate()
		{
			if (!DateCreated.HasValue || !DateUpdated.HasValue) return true;
			{
				return DateUpdated.Value.Date > DateCreated.Value.Date;
			}
		}

		public bool NumSpaceGreaterThanZero()
		{
			if (!NumSpaces.HasValue) return true;
			return NumSpaces.Value > 0;
		}

		public bool MaxStayGreaterThanZero()
		{
			if (!MaxStay.HasValue) return true;
			return MaxStay.Value > 0;
		}
	}
}
