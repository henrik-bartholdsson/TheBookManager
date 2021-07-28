using Domain.Entities;
using Domain.Repository.Contract;
using System;
using System.Collections.Generic;

namespace Application.Service
{
    public class BookService
    {
        private readonly IRepository<Author, Guid> _authors;
        public BookService(IRepository<Author, Guid> authors)
        {
            _authors = authors;
        }


        public void Add()
        {
            var author1 = new Author { Contact = "asd@asd.com", Name = "Arne Anka" };
            var author2 = new Author { Contact = "gfhjtg@asd.com", Name = "Eva Andersson" };
            var author3 = new Author { Contact = "ertn5@asd.com", Name = "Janne Bengtsson" };
            _authors.Insert(author1);
            _authors.Insert(author2);
            _authors.Insert(author3);
        }

        public IEnumerable<Author> GetAll()
        {
            var authors = _authors.GetAll().Result;

            return authors;
        }


    }
}
