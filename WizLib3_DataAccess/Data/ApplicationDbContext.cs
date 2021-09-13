using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using WizLib3_Model.Models;
using WizLib3_Model.Models_Fluent;


namespace WizLib3_DataAccess.Data
{
	public class ApplicationDbContext :DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Genre> Genres { get; set; }
		public DbSet<Book> Books { get; set; }

		public DbSet<BookDetail> BookDetails { get; set; }

		public DbSet<Author> Authors { get; set; }
		public DbSet<Publisher> Publishers { get; set; }

		DbSet<BookAuthor> BookAuthors { get; set; }

		//	Fluent  models

		public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
		public DbSet<Fluent_Author> Fluent_Authors { get; set; }
		public DbSet<Fluent_Book> Fluent_Books { get; set; }
		public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }

		//	public DbSet<Fluent_BookAuthor> Fluent_BookAuthors { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
								// composite key for BookAuthor model
			modelBuilder.Entity<BookAuthor>()
				.HasKey(ba => new { ba.Author_Id, ba.Book_Id });



		#region   Fluent Api

			//	Fluent_BookDetail
			modelBuilder.Entity<Fluent_BookDetail>()
							.HasKey(fbd => new { fbd.BookDetail_Id });
			modelBuilder.Entity<Fluent_BookDetail>()
							.Property(b => b.NumberOfChapters)
							.IsRequired();

			//	Fluent Book
			modelBuilder.Entity<Fluent_Book>()
							.HasKey(fb => fb.Book_Id);
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.ISBN)
							.HasMaxLength(15)
							.IsRequired();
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.Title)
							.IsRequired();
			modelBuilder.Entity<Fluent_Book>()
							.Property(fb => fb.Price)
							.IsRequired();

			//	Fluent Author
			modelBuilder.Entity<Fluent_Author>()
							.HasKey(fa => fa.Author_Id);
			modelBuilder.Entity<Fluent_Author>()
							.Property(fa => fa.FirstName)
							.IsRequired();
			modelBuilder.Entity<Fluent_Author>()
							.Property(fa => fa.LastName)
							.IsRequired();
			modelBuilder.Entity<Fluent_Author>()
							.Ignore(fa => fa.FullName);

			//	Fluent_Publisher
			modelBuilder.Entity<Fluent_Publisher>()
							.HasKey(fa => fa.Publisher_Id);
			modelBuilder.Entity<Fluent_Publisher>()
							.Property(fa => fa.Name)
							.IsRequired();
			modelBuilder.Entity<Fluent_Publisher>()
							.Property(fa => fa.Location)
							.IsRequired();

		#endregion

		}

	}
}
