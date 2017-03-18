using System.Web.Http;
using BookShelf.Configuration;
using Owin;

namespace BookShelf
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(new HttpConfiguration().RegisterDryIoc().RegisterWebApi());
        }
    }
}