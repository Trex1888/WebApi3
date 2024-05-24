using WebApi3.Models;

namespace WebApi3.Interfaces
{
	public interface ICategoryRepository
	{
		ICollection<Category> GetCategories();

		Category GetCategory(int id);

		ICollection<Pokemon> GetPokemonByCategory(int categoryId);

		bool CategoryExists(int id);

		bool CreateCategory(Category category);

		bool Save();
	}
}
