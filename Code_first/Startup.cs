using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code_first.Startup))]
namespace Code_first
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
