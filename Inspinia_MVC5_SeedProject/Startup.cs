using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BackBench.Startup))]
namespace BackBench
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
