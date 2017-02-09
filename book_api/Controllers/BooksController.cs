using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace book_api.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values, this needs to return a json or xml of books and their descriptors for tabular data
        public IEnumerable<string> Get()
        {
            return new string[] { "book1", "book2" };
        }

        // GET api/values/5, for accessing a single book? unneeded but possibly cool
        public string Get(int id)
        {
            return $"value: {id}";
        }
    }
}
