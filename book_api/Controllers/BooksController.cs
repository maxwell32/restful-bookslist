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
        // GET ./books
        public IEnumerable<Book> Get()
        {
            //return list of books
            return populateList();
        }

        // GET ./books/{id}, for accessing a single book in the list
        public Book Get(int id)
        {
            //temporary copy of the book list
            var tempBookList = populateList();
            
            //very basic validation of id, if its greater than the size of the list, make it the last element in the list
            if(id > tempBookList.Count-1)
            {
                id = tempBookList.Count-1;
            }
            //return the specific book
            return tempBookList.ElementAt(id);
        }
        /*
         * Create a new list of Book objects
         * Initialize the list with 3 hard coded books
         * Return the list 
         */
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

    //class for Book object with setters and getters
    public class Book
    {
        public string title { get; set; }
        public string authorFName { get; set; }
        public string authorLName { get; set; }
        public string genre { get; set; }
        public string publisher { get; set; }
    }
}
