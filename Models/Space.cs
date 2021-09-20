using System;
using System.Collections.Generic;
using System.Text;

namespace MilSiteCore.Models
{
	public class Space
	{
		public int SpaceId { get; set; }
		public int SpaceNumber { get; set; }
		public int SpacePhotoId { get; set; }

		public List<Image> Images { get; set; }
	}
}
