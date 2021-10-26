using System;
using System.Collections.Generic;
using System.Text;


namespace WizLib3_Model.Models_Fluent
{
	public class Fluent_BookAuthor
	{
		//	[Key]				composite key
		public int Book_Id { get; set; }

		//	[Key]				composite key
		public int Author_Id { get; set; }


		//	Many-To-Many relationship : Book - Author

		public Fluent_Book Fluent_Book { get; set; }

		public Fluent_Author Fluent_Author { get; set; }

	}
}
