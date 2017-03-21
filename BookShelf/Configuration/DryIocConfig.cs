using System.Web.Http;
using BookShelf.Providers;
using DryIoc;
using DryIoc.WebApi;

namespace BookShelf.Configuration
{
    internal static class DryIocConfig
    {
        public static HttpConfiguration RegisterDryIoc(this HttpConfiguration config)
        {
            var container = new Container();
            container.Register<IAuthorProvider, LocalAuthorProvider>();
            container.Register<IBookProvider, LocalBooksProvider>();
            container.WithWebApi(config);

            return config;
        }
    }
}