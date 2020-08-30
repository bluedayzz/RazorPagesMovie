using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Group
	{
		public int ID { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }
		[Required]
		public bool Use { get; set; }
	}
}
