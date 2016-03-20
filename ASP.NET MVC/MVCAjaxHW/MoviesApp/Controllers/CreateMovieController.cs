namespace MoviesApp.Controllers
{
    using Models;
    using System.Web.Mvc;
    using ViewModels;
    public class CreateMovieController : Controller
    {
        private MoviesDbContext db = new MoviesDbContext();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMovie(CreateMovieModel movieObj)
        {
            InsertMovie(movieObj);
            ViewBag.MovieTitle = movieObj.Title;
            return this.PartialView("_Created",movieObj);
        }

        private void InsertMovie(CreateMovieModel model)
        {
            var movie = new Movie();
            movie.Director = model.Director;
            movie.Title = model.Title;
            movie.LeadingFemaleRole = model.FemaleRole;
            movie.LeadingMaleRole = model.MaleRole;
            movie.Studio = model.Studio;
            movie.StudioAddress = model.StudioAddress;
            movie.Year = model.Year;
            this.db.Movies.Add(movie);
            this.db.SaveChanges();
        }
    }
}