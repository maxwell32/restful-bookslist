# restful-bookslist

#####Sample project

Created a two REST API endpoints that responds to GET requests
returning and XML document with the format:
<Book>
  <authorFName />
  <authorLName />
  <genre />
  <publisher />
  <title />
</Book>

#####localhost:XXXXX/books
Returns the complete list of books

#####localhost:XXXXX/books/{id}
Returns a specific book in the list at the supplied index, if the index if out of range
it will return the last book in the list

#####localhost:XXXXX
This page contains a button that will make an AJAX call when clicked, and populate a table
with book information from the response (calls: localhost:XXXXX/books)