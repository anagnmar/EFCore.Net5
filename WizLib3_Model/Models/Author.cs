using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models
{
	public class Author
	{
		[Key]
		public int Author_Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }
		public string Location { get; set; }

		//	Many-To-Many relationship: Book - Author

		public ICollection<BookAuthor> BookAuthors { get; set; }
	//	public virtual ICollection<BookAuthor> BookAuthors { get; set; }



		[NotMapped]
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

	}
}
