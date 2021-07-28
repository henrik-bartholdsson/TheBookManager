using Domain.Entities;
using Domain.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class BookRepository : IRepository<Book, Guid>
    {
        private readonly DbContextOptions<BookManagerDbContext> _options;

        public BookRepository(DbContextOptions<BookManagerDbContext> options)
        {
            _options = options;
        }

        public async Task Delete(Guid id)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var book = await context.Books.FirstOrDefaultAsync(x => x.Id == id);

                if (book != null)
                    context.Remove(book);

                await Save(context);
            }
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var books = await context.Books.ToListAsync();
                return books;
            }
        }

        public async Task<Book> GetById(Guid id)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var book = await context.Books.FirstOrDefaultAsync(x => x.Id == id);
                return book;
            }
        }

        public async Task<Book> Insert(Book entity)
        {
            using (var context = new BookManagerDbContext(_options))
            {
                var book = await context.AddAsync(entity);
                await Save(context);
                return book.Entity;
            }
        }

        public async Task Save(BookManagerDbContext context)
        {
                await context.SaveChangesAsync();
        }
    }
}
