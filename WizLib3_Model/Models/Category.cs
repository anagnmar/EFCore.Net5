using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models
{
	[Table("tbl_category")]
	public class Category
	{
		[Key]
		public int Category_Id { get; set; }

		public string Name { get; set; }

	}
}
