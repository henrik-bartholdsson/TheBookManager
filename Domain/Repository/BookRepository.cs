using Domain.Entities;
using Domain.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public class BookRepository : IRepository<Book, int>
    {
        public Task<IEnumerable<Book>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Insert(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Save()
        {
            throw new NotImplementedException();
        }
    }
}
