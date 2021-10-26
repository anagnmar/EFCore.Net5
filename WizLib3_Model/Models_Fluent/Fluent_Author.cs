﻿using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models_Fluent
{
	public class Fluent_Author
	{
		public int Author_Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }
		public string Location { get; set; }


		//	Many-To-Many relationship : Book - Author

		public ICollection<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }


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
