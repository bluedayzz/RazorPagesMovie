using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesMovie.Models
{
	public class Userh
	{
		public int ID { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }
		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Email { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Pwd { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string PwdTemp { get; set; }

		[Display(Name = "Create Date")]
		[DataType(DataType.Date)]
		public DateTime CreateDate { get; set; }

		[Display(Name = "Last Login Date")]
		[DataType(DataType.Date)]
		public DateTime LastLoginDate { get; set; }
		public int IdGroup { get; set; }
	}
}
