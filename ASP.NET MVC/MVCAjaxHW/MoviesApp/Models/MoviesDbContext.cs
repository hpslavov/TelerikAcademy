using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class MoviesDbContext : IdentityDbContext<User>
    {
        public MoviesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static MoviesDbContext Create()
        {
            return new MoviesDbContext();
        }

        public IDbSet<Movie> Movies { get; set; }
    }
}