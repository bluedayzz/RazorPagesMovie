using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Goods
	{
		public int ID { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }
		[Required]
		public int Category00 { get; set; }
		[Required]
		public int Category01 { get; set; }
		[Required]
		public int Category02 { get; set; }
		[Required]
		public bool Use { get; set; }
		[Required]
		public int IdUser { get; set; }
		[Required]
		public int IdGroup{ get; set; }
	}
}
