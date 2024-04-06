using System.ComponentModel.DataAnnotations;

namespace RazorPlog.Models
{
	public class Type
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
