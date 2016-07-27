using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckBoxDwopdownWithJquery.Startup))]
namespace CheckBoxDwopdownWithJquery
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
