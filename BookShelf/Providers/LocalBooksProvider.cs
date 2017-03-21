using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BookShelf.Models;

namespace BookShelf.Providers
{
    public class LocalBooksProvider : IBookProvider
    {
        private readonly List<Book> _books;

        public LocalBooksProvider()
        {
            this._books = new List<Book>
            {
                new Book{Id = 1, AuthorId = 1, Title = "Da Vinci Code", Description = "Good"},
                new Book{Id = 2, AuthorId = 1, Title = "Angels and Demons", Description = "Good"},
                new Book{Id = 3, AuthorId = 1, Title = "Inferno", Description = "Good"},
                new Book{Id = 4, AuthorId = 2, Title = "Chronicles of Echo", Description = "Good too"}
            };
        }
        public async Task<Book[]> GetBooks(int? authorId)
        {
            return authorId.HasValue
                ? await Task.FromResult(this._books.ToArray())
                : await Task.FromResult(this._books.Where(b => b.AuthorId == authorId.Value).ToArray());
        }
    }
}