using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Code_test.Client.Startup))]
namespace Code_test.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
