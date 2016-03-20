using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.ViewModels
{
    public class CreateMovieModel
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string Studio { get; set; }
        public string StudioAddress { get; set; }
        public string MaleRole { get; set; }
        public string FemaleRole { get; set; }
    }
}