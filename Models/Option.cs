using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Option
	{
		public int ID { get; set; }
		public int IdGoods { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }

		[Required]
		public bool Use { get; set; }
	}
}
