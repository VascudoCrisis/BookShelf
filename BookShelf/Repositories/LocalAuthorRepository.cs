using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookShelf.Models;

namespace BookShelf.Repositories
{
    public sealed class LocalAuthorRepository
    {
        private static volatile LocalAuthorRepository instance;
        private static readonly object syncRoot = new object();


        private readonly List<Author> _authors;
        private LocalAuthorRepository()
        {
            this._authors = new List<Author>
            {
                new Author{Id = 1, LastName = "Brown", FirstName = "Den"},
                new Author{Id = 1, LastName = "Fry", FirstName = "Max"}
            };
        }

        public static LocalAuthorRepository Instance
        {
            get
            {
                if (instance == null)
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LocalAuthorRepository();
                    }

                return instance;
            }
        }

        public async Task<Author[]> GetAuthors()
        {
            return await Task.FromResult(this._authors.ToArray());
        }

        public async Task<bool> AddAuthor(Author author)
        {
            try
            {
                this._authors.Add(author);
                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }

        public async Task<bool> UpdateAuthor(Author author)
        {
            try
            {
                var editedAuthor = this._authors.Single(a => a.Id == author.Id);

                editedAuthor.FirstName = author.FirstName;
                editedAuthor.LastName = author.LastName;
                editedAuthor.MiddleName = author.MiddleName;
                editedAuthor.Description = author.Description;

                return await Task.FromResult(true);
            }
            catch
            {
                return await Task.FromResult(false);
            }
        }
    }
}