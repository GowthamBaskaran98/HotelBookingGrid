using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelBookingSystem.Startup))]
namespace HotelBookingSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
