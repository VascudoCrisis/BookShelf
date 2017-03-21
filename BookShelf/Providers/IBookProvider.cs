using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using BookShelf.Models;

namespace BookShelf.Providers
{
    public interface IBookProvider
    {
        Task<Book[]> GetBooks(int? authorId);
    }
}