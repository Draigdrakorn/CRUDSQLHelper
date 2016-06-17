using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUD_process.Startup))]
namespace CRUD_process
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
