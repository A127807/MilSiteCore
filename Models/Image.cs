namespace MilSiteCore.Models
{
	public class Image
	{
		public int ImageId { get; set; }
		public string Photo { get; set; }
		public int SpaceId { get; set; }
		public Space Space { get; set; }
	}
}