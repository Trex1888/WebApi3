﻿using WebApi3.Models;

namespace WebApi3.Interfaces
{
	public interface IReviewRepository
	{
		ICollection<Review> GetReviews();
		Review GetReview(int reviewId);
		ICollection<Review> GetReviewsOfAPokemon(int pokeId);
		bool ReviewExists(int reviewId);
		bool CreateReview(Review review);
		bool UpdateReview(Review review);
		bool DeleteReview(Review review);
		bool DeleteReviews(List<Review> reviews);
		bool Save();
	}
}
