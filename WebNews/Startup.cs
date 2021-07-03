using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNews.Startup))]
namespace WebNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
