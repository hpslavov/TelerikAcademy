namespace TwitterLike.Data
{
    using Contracts;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    public class TwitterLikeDbContext : IdentityDbContext<User>, ITwitterLikeDbContext
    {
        public TwitterLikeDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TwitterLikeDbContext Create()
        {
            return new TwitterLikeDbContext();
        }
    }
}
