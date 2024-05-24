using WebApi3.Models;

namespace WebApi3.Dto
{
	public class CountryDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public ICollection<Owner> Owners { get; set; }
	}
}
