using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDocuments.Startup))]
namespace WebDocuments
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
