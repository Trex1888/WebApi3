using WebApi3.Data;
using WebApi3.Interfaces;
using WebApi3.Models;

namespace WebApi3.Repositories
{
	public class ReviewRepository : IReviewRepository
	{
		private readonly DataContext _context;
		public ReviewRepository(DataContext context)
		{
			_context = context;
		}

		public Review GetReview(int reviewId)
		{
			return _context.Reviews.Where(r => r.Id == reviewId).FirstOrDefault();
		}

		public ICollection<Review> GetReviews()
		{
			return _context.Reviews.ToList();
		}

		public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
		{
			return _context.Reviews.Where(r => r.Pokemon.Id == pokeId).ToList();
		}

		public bool ReviewExists(int reviewId)
		{
			return _context.Reviews.Any(r => r.Id == reviewId);
		}
	}
}
