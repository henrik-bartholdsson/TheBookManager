using Domain.Entities;
using Domain.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class AuthorRepository : IRepository<Author, Guid>
    {
        private readonly DbContextOptions<BookManagerDbContext> _options;

        public AuthorRepository(DbContextOptions<BookManagerDbContext> options)
        {
            _options = options;
        }

        public async Task Delete(Guid id)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);

                if (author != null)
                    context.Remove(author);

                await Save(context);
            }
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var authors = await context.Authors.ToListAsync();
                return authors;
            }
        }

        public async Task<Author> GetById(Guid id)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var author = await context.Authors.FirstOrDefaultAsync(x => x.Id == id);
                return author;
            }

        }

        public async Task<Author> Insert(Author entity)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var author = await context.AddAsync(entity);
                await Save(context);
                return author.Entity;
            }
        }

        public async Task Save(BookManagerDbContext context)
        {
                await context.SaveChangesAsync();
        }
    }
}
