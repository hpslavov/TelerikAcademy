namespace TwitterLike.App_Start
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public static class DbConfig
    {
        public static void Init()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TwitterLikeDbContext, Configuration>());
        }
    }
}