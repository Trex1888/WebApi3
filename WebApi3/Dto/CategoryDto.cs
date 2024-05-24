using WebApi3.Models;

namespace WebApi3.Dto
{
	public class CategoryDto
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public ICollection<PokemonCategory> PokemonCategories { get; set; }
	}
}
