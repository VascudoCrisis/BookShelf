using System.Web.Http;
using System.Web.Http.Cors;

namespace BookShelf.Configuration
{
    internal static class WebApiConfig
    {
        internal static HttpConfiguration RegisterWebApi(this HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);

            return config;
        }
    }
}