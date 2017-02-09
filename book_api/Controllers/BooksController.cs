using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace book_api.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values, this needs to return a json or xml of books and their descriptors for tabular data
        public IEnumerable<Book> Get()
        {
            List<Book> bookList = new List<Book>();
            //create book objects and add to the list
            Book kiteRunner = new Book
            {
                Title = "The Kite Runner",
                Author = "Khaled H.",
                Genre = "Realistic Fiction",
                Publisher = "Penguin"
            };
            bookList.Add(kiteRunner);

            //return list of books
            return bookList;
        }

        // GET api/values/5, for accessing a single book? unneeded but possibly cool
        public string Get(int id)
        {
            return $"value: {id}";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
    }
}
