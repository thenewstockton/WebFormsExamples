using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsExamples.Startup))]
namespace WebFormsExamples
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
