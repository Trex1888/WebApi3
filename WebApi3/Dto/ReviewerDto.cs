using WebApi3.Models;

namespace WebApi3.Dto
{
	public class ReviewerDto
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public ICollection<Review> Reviews { get; set; }

	}
}
