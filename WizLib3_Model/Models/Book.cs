using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models
{
	public class Book
	{
		[Key]
		public int Book_Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		[MaxLength(15)]     // real MaxLength for ISBN is 13 chars.
		public string ISBN { get; set; }

		[Required]
		public double Price { get; set; }


		//	One-To-One relationship: Book - BookDetail
		[ForeignKey("BookDetail")]
		public int BookDetail_Id { get; set; }
		public BookDetail BookDetail { get; set; }


		//	One-To-Many relationship: Book - BookDetail
		[ForeignKey("Publisher")]
		public int Publisher_Id { get; set; }
		public Publisher Publisher { get; set; }


		public ICollection<BookAuthor> BookAuthors { get; set; }




		/*	[NotMapped]
			-----------
			public string PriceRange { get; set; }
		*/

	}
}
