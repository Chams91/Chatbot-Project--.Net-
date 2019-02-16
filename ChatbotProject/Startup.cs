using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatbotProject.Startup))]
namespace ChatbotProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
