using WebApi3.Models;

namespace WebApi3.Dto
{
	public class ReviewDto
	{
		public int? Id { get; set; }
		public string? Title { get; set; }
		public string? Text { get; set; }
		public int? Rating { get; set; }
		public Reviewer Reviewer { get; set; }
		public Pokemon Pokemon { get; set; }
	}
}
