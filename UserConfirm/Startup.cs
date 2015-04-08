using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserConfirm.Startup))]
namespace UserConfirm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
