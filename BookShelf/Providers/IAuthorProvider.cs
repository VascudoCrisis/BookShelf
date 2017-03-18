using System.Threading.Tasks;
using BookShelf.Models;

namespace BookShelf.Providers
{
    public interface IAuthorProvider
    {
        Task<Author[]> GetAuthors();
        Task<bool> AddAuthor(Author author);
        Task<bool> UpdateAuthor(Author author);
    }
}
