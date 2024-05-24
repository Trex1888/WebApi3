﻿using WebApi3.Data;
using WebApi3.Interfaces;
using WebApi3.Models;

namespace WebApi3.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private DataContext _context;

		public CategoryRepository(DataContext context)
		{
			_context = context;
		}
		public bool CategoryExists(int id)
		{
			return _context.Categories.Any(c => c.Id == id);
		}

		public bool CreateCategory(Category category)
		{
			_context.Add(category);
			_context.SaveChanges();
			return Save();
		}

		public ICollection<Category> GetCategories()
		{
			return _context.Categories.ToList();
		}

		public Category GetCategory(int id)
		{
			return _context.Categories.Where(e => e.Id == id).FirstOrDefault();
		}

		public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
		{
			return _context.PokemonCategories.Where(e => e.CategoryId == categoryId).Select(c => c.Pokemon).ToList();
		}

		public bool Save()
		{
			var saved = _context.SaveChanges();
			return saved > 0 ? true : false;
		}
	}
}
