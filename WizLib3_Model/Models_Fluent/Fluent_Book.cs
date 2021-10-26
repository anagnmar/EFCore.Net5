using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models_Fluent
{
	public class Fluent_Book
	{
		public int Book_Id { get; set; }

		public string Title { get; set; }

		public string ISBN { get; set; }

		public double Price { get; set; }

		//	One-To-One relationship
		public int BookDetail_Id { get; set; }
		public Fluent_BookDetail Fluent_BookDetail { get; set; }

		//	One-To-Many relationship
		public int Publisher_Id { get; set; }
		public Fluent_Publisher Fluent_Publisher { get; set; }

		//	Many-To-Many relationship : Book - Author

		public ICollection<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }

	}
}
