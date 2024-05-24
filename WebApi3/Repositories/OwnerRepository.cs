﻿using WebApi3.Data;
using WebApi3.Interfaces;
using WebApi3.Models;

namespace WebApi3.Repositories
{
	public class OwnerRepository : IOwnerRepository
	{
		private readonly DataContext _context;

		public OwnerRepository(DataContext context)
		{
			_context = context;
		}

		public Owner GetOwner(int ownerId)
		{
			return _context.Owners.Where(e => e.Id == ownerId).FirstOrDefault();
		}

		public ICollection<Owner> GetOwnerOfAPokemon(int pokeId)
		{
			return _context.PokemonOwners.Where(p => p.Pokemon.Id == pokeId).Select(o => o.Owner).ToList();
		}

		public ICollection<Owner> GetOwners()
		{
			return _context.Owners.ToList();
		}

		public ICollection<Pokemon> GetPokemonByOwner(int ownerId)
		{
			return _context.PokemonOwners.Where(p => p.Owner.Id == ownerId).Select(p => p.Pokemon).ToList();
		}

		public bool OwnerExists(int ownerId)
		{
			return _context.Owners.Any(o => o.Id == ownerId);
		}
	}
}
