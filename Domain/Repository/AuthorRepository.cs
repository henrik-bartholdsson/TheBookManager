using Domain.Entities;
using Domain.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    class AuthorRepository : IRepository<Author, int>
    {
        public Task<IEnumerable<Author>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> Insert(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> Save()
        {
            throw new NotImplementedException();
        }
    }
}
