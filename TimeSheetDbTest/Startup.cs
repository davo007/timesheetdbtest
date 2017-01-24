using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSheetDbTest.Startup))]
namespace TimeSheetDbTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
