using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Author
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
