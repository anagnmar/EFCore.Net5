using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models
{
	public class Publisher
	{
		[Key]
		public int Publisher_Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Location { get; set; }


	//	navigation properties

		public List<Book> Books { get; set; }

	}
}
