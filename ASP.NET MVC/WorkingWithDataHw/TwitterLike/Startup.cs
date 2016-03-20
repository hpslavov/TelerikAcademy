using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterLike.Startup))]
namespace TwitterLike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
