using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iAttended.Startup))]
namespace iAttended
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
