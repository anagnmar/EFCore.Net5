﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WizLib3_Model.Models_Fluent
{
	public class Fluent_BookDetail
	{
		public int BookDetail_Id { get; set; }

		public int NumberOfChapters { get; set; }

		public int NumberOfPages { get; set; }

		public double Weight { get; set; }

	}
}