using MoviesApp.Migrations;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesApp.App_Start
{
    public static class DbConfig
    {
        public static void Init()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MoviesDbContext, Configuration>());
        }
    }
}