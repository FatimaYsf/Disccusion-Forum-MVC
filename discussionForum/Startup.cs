using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(discussionForum.Startup))]
namespace discussionForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
