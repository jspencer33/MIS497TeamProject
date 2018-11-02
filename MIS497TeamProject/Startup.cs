using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS497TeamProject.Startup))]
namespace MIS497TeamProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
