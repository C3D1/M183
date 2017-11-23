using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Single_Sign_ON.Startup))]
namespace Single_Sign_ON
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
