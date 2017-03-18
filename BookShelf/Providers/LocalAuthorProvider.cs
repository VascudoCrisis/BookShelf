using System.Threading.Tasks;
using BookShelf.Models;
using BookShelf.Repositories;

namespace BookShelf.Providers
{
    public class LocalAuthorProvider : IAuthorProvider
    {
        public async Task<Author[]> GetAuthors()
        {
            return await LocalAuthorRepository.Instance.GetAuthors();
        }

        public async Task<bool> AddAuthor(Author author)
        {
            return await LocalAuthorRepository.Instance.AddAuthor(author);
        }

        public async Task<bool> UpdateAuthor(Author author)
        {
            return await LocalAuthorRepository.Instance.UpdateAuthor(author);
        }
    }
}