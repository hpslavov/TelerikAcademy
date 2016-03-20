namespace MoviesApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string LeadingMaleRole { get; set; }
        public int? LeadingMaleAge { get; set; }
        public string LeadingFemaleRole { get; set; }
        public int? LeadingFemaleAge { get; set; }
        public string Studio { get; set; }
        public string StudioAddress { get; set; }
    }
}