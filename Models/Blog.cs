﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using crud_system.validations;

namespace RazorPlog.Models
{
	public class Blog
	{
		[Key]
		public int? Id { get; set; }
		[Required]
		[NameVal] //is used to prevent numbers in the first char in Name 
		public string Name { get; set; }
		[Required]
		[Length(10, 100, ErrorMessage = "The Range is between 10 and 100 character")]
		public string Discription { get; set; }
		[Required]
		public bool Enable { get; set; }
	
		public int ?TypeId { get; set; }
		[ForeignKey("TypeId")]

		public Type? type { get; set; }
	}
}
