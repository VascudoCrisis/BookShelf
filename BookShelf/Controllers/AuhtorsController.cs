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
    [RoutePrefix("authors")]
    public class AuhtorsController : ApiController
    {
        private readonly IAuthorProvider _provider;

        public AuhtorsController(IAuthorProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        [Route("")]
        public async Task<Author[]> GetAuthors()
        {
            return await this._provider.GetAuthors();
        }

        [HttpPost]
        [Route("")]
        public async Task<bool> UpdateAuthor(Author author)
        {
            return await this._provider.UpdateAuthor(author);
        }

        [HttpPut]
        [Route("")]
        public async Task<bool> AddAuthor(Author author)
        {
            return await this._provider.AddAuthor(author);
        }
    }
}
