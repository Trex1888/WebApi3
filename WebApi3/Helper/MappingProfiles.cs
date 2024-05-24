using AutoMapper;
using WebApi3.Dto;
using WebApi3.Models;

namespace WebApi3.Helper
{
	public class MappingProfiles : Profile
	{
		public MappingProfiles()
		{
			CreateMap<Pokemon, PokemonDto>();
			CreateMap<Category, CategoryDto>();
			CreateMap<Country, CountryDto>();
			CreateMap<Owner, OwnerDto>();
			CreateMap<Review, ReviewDto>();
			CreateMap<Reviewer, ReviewerDto>();
		}
	}
}
