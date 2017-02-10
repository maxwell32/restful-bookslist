# restful-bookslist

#####Sample project

Created a two REST API endpoints that responds to GET requests
with an XML response, written in ASP.NET 4
  

#####localhost:XXXXX/books
Returns the complete list of books
![alt text](http://imgur.com/mjMTrct.png "Book List")

#####localhost:XXXXX/books/{id}
Returns a specific book in the list at the supplied index, if the index if out of range
it will return the last book in the list
![alt text](http://imgur.com/49e7FBW.png "Specific Book")

#####localhost:XXXXX
This page contains a button that will make an AJAX call when clicked, and populate a table
with book information from the response (calls: localhost:XXXXX/books)
![alt text](http://imgur.com/KRj6EN9.png "Pre AJAX")
![alt text](http://imgur.com/53fRtoz.png "Post AJAX")
