using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Product_Test.Startup))]
namespace Product_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
