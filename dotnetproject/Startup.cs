using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotnetproject.Startup))]
namespace dotnetproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
