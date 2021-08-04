using Application.Service;
using Domain.Entities;
using Domain.Repository.Contract;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Infrastructure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IRepository<Author, Guid> _authorRepository;
        public IEnumerable<Author> authors;
        public string someInfo;
        public string moreInfo;

        public IndexModel(ILogger<IndexModel> logger, IRepository<Author, Guid> authorRepository)
        {
            _logger = logger;
            _authorRepository = authorRepository;
        }

        public void OnGet()
        {
            var service = new BookService(_authorRepository);
            //service.Add();
            authors = service.GetAll();
            someInfo = "The page works fine! :)";
            moreInfo = "And this is awsome!";
        }
    }
}
