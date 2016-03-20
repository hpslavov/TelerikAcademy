namespace MoviesApp.Controllers
{
    using Models;
    using System.Web.Mvc;
    using System.Linq;
    using ViewModels;
    public class ListMoviesController : Controller
    {
        public MoviesDbContext movies = new MoviesDbContext();

        public ActionResult All()
        {
            var queryMovies = this.movies.Movies
                                .OrderBy(m => m.ID)
                                .Select(m => new AllMoviesViewModel
                                {
                                    Title = m.Title,
                                    Director = m.Director,
                                    Year = m.Year,
                                    LeadingFemaleRole = m.LeadingFemaleRole,
                                    LeadingMaleRole = m.LeadingMaleRole,
                                    Studio = m.Studio,

                                }).ToList();
            return View(queryMovies);
        }

        //public ActionResult AllMovies()
        //{
        //    var moviesData = movies.Movies.ToList();
        //    var data = moviesData.Select(m => new AllMoviesViewModel
        //    {
        //        Director = m.Director,
        //        Title = m.Title,
        //        LeadingMaleRole = m.LeadingMaleRole,
        //        LeadingFemaleRole = m.LeadingFemaleRole,
        //        Year = m.Year,
        //        Studio = m.Studio
        //    });

        //    return Json(data, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Search(string query)
        {
            var queryMovies = this.movies.Movies
                                .Where(m => m.Title.Contains(query))
                                .Select(AllMoviesViewModel.FromMovie).ToList();
                                //{
                                    //Title = m.Title,
                                    //Director = m.Director,
                                    //Year = m.Year,
                                    //LeadingFemaleRole = m.LeadingFemaleRole,
                                    //LeadingMaleRole = m.LeadingMaleRole,
                                    //Studio = m.Studio,

                               // }).ToList();
            return this.PartialView("_MoviesResult", queryMovies);
        }

        public ActionResult Edit(AllMoviesViewModel obj)
        {
            return this.PartialView("_EditPartial",obj);
        }

        public void EditMovie(AllMoviesViewModel obj)
        {
            var movie = this.movies.Movies.Where(m => m.Title == obj.Title).FirstOrDefault();
            movie.Year = obj.Year;
            movie.Director = obj.Director;
            movie.LeadingMaleRole = obj.LeadingMaleRole;
            movie.Studio = obj.Studio;
            movie.LeadingFemaleRole = obj.LeadingFemaleRole;
            this.movies.SaveChanges();
        }
    }
}