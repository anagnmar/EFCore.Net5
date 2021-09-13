using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models
{
	public class BookAuthor
	{

		[ForeignKey("Book")]			//	compositeKey **
		public int Book_Id { get; set; }

		[ForeignKey("Author")]			//	compositeKey **
		public int Author_Id { get; set; }

	//	navigation properties

		public Book Book { get; set; }

		public Author Author { get; set; }

	}
}
