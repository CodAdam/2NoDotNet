using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2NoDotNet.Startup))]
namespace _2NoDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
