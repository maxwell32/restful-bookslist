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
            //return list of books
            return populateList();
        }

        // GET api/values/5, for accessing a single book? unneeded but possibly cool
        public Book Get(int id)
        {
            var tempBookList = populateList();
            
            if(id > tempBookList.Count-1)
            {
                id = tempBookList.Count-1;
            }
            return tempBookList.ElementAt(id);
        }

        private List<Book> populateList()
        {
            List<Book> bookList = new List<Book>();
            //kite runner
            Book kiteRunner = new Book
            {
                title = "The Kite Runner",
                authorFName = "Khaled",
                authorLName = "Hosseini",
                genre = "Fiction",
                publisher = "Riverhead Books"
            };
            bookList.Add(kiteRunner);

            //the road
            Book theRoad = new Book
            {
                title = "The Road",
                authorFName = "Cormac",
                authorLName = "McCarthy",
                genre = "Fiction",
                publisher = "Vintage International"
            };
            bookList.Add(theRoad);

            //the road
            Book daVinciCode = new Book
            {
                title = "The Da Vinci Code",
                authorFName = "Dan",
                authorLName = "Brown",
                genre = "Fiction",
                publisher = "Anchor Books"
            };
            bookList.Add(daVinciCode);

            return bookList;
        }
    }

    public class Book
    {
        public string title { get; set; }
        public string authorFName { get; set; }
        public string authorLName { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
    }
}
