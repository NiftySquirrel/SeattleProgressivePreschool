using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SeattleProgressivePreschoolService.Startup))]

namespace SeattleProgressivePreschoolService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}