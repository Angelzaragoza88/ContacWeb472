using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContacWeb472.Startup))]
namespace ContacWeb472
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
