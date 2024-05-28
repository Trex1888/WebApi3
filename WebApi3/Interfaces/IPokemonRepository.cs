using WebApi3.Dto;
using WebApi3.Models;

namespace WebApi3.Interfaces
{
	public interface IPokemonRepository
	{
		ICollection<Pokemon> GetPokemons();
		Pokemon GetPokemon(int id);
		Pokemon GetPokemon(string name);
		Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate);
		decimal GetPokemonRating(int pokeId);
		bool PokemonExists(int pokeId);
		bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);
		bool UpdatePokemon(int ownerId, int categoryId, Pokemon pokemon);
		bool DeletePokemon(Pokemon pokemon);
		bool Save();
	}
}
