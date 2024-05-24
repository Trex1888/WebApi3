﻿using WebApi3.Models;

namespace WebApi3.Interfaces
{
	public interface ICountryRepository
	{
		ICollection<Country> GetCountries();

		Country GetCountry(int id);

		Country GetCountryByOwner(int ownerId);

		ICollection<Owner> GetOwnersFromACountry(int countryId);

		bool CountryExists(int id);
	}
}
