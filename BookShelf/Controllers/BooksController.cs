using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BookShelf.Models;
using BookShelf.Providers;

namespace BookShelf.Controllers
{
    [RoutePrefix("books")]
    public class BooksController : ApiController
    {
        private readonly IBookProvider _provider;

        public BooksController(IBookProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        [Route("")]
        public async Task<Book[]> GetBooks(int? authorId = null)
        {
            return await this._provider.GetBooks(authorId);
        }
    }
}
