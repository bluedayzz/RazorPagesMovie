using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
	public class Item
	{
		public int ID { get; set; }
		public int IdOption { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }

		[DataType(DataType.Currency)]
		[Column(TypeName = "decimal(18, 0)")]
		public decimal Price { get; set; }

		[Required]
		public bool Use { get; set; }


	}

}
