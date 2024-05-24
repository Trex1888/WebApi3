using WebApi3.Models;

namespace WebApi3.Dto
{
	public class PokemonDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public DateTime? BirthDate { get; set; }

		public ICollection<Review> Reviews { get; set; }

		public ICollection<PokemonOwner> PokemonOwners { get; set; }

		public ICollection<PokemonCategory> PokemonCategories { get; set; }
	}
}
