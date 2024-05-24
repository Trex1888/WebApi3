using WebApi3.Models;

namespace WebApi3.Interfaces
{
	public interface IOwnerRepository
	{
		ICollection<Owner> GetOwners();

		Owner GetOwner(int ownerId);

		ICollection<Owner> GetOwnerOfAPokemon(int pokeId);

		ICollection<Pokemon> GetPokemonByOwner(int ownerId);

		bool OwnerExists(int ownerId);

	}
}
