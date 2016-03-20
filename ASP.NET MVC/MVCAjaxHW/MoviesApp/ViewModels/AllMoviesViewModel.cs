
using MoviesApp.Models;
using System;
using System.Linq.Expressions;

namespace MoviesApp.ViewModels
{
    public class AllMoviesViewModel
    {
        public static Expression<Func<Movie, AllMoviesViewModel>> FromMovie
        {
            get
            {
                return movie => new AllMoviesViewModel
                {
                    Title = movie.Title,
                    Year = movie.Year,
                    Studio = movie.Studio,
                    Director = movie.Director,
                    LeadingMaleRole = movie.LeadingMaleRole,
                    LeadingFemaleRole = movie.LeadingFemaleRole
                };
            }
        }

        public string Title { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string LeadingMaleRole { get; set; }
        public string LeadingFemaleRole { get; set; }
        public string Studio { get; set; }
    }
}