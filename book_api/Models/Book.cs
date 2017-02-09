using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace book_api.Models
{
    

    public class Book
    {
        string title, author, genre, publisher;

        public Book(string title, string auth, string genre, string pub)
        {
            this.title = title;
            this.author = auth;
            this.genre = genre;
            this.publisher = pub;
        }
    }
}