using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using WizLib3_DataAccess.Data;
using WizLib3_Model.Models;

namespace WizLib3.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ApplicationDbContext _db;

		public CategoryController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<Category> categList = _db.Categories.ToList();

			return View(categList);
		}

		public IActionResult Upsert(int? id)
		{
			Category categ = new Category();

			if (id == null)
				return View(categ);
			//	for Edit
			categ = _db.Categories.FirstOrDefault(c => c.Category_Id == id);
			if (categ == null)
			{
				return NotFound();
			}
			return View(categ);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Upsert(Category categ)
		{

			if (ModelState.IsValid)
			{
				if(categ.Category_Id == 0)
				{
					//	create new category
					_db.Categories.Add(categ);
				// OR	_db.Add(categ);
				}
				else
				{
					//	update an existing category
					_db.Categories.Update(categ);
				// OR	_db.Update(categ);
				}
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(categ);
		}


		public IActionResult Delete(int? id)
		{
			var delCateg = _db.Categories.Find(id);

			_db.Categories.Remove(delCateg);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

	}
}
