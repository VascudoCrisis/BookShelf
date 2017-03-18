using System.Web.Http;

namespace BookShelf.Configuration
{
    internal static class WebApiConfig
    {
        internal static HttpConfiguration RegisterWebApi(this HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            return config;
        }
    }
}