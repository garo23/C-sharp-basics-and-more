using System;
using System.Collections;
class Library {
    private List <Book> _BooksInLibrary;
    private string _Name;

    public  List<Book> addBook(Book b)
    {
        _BooksInLibrary.Add(b);
        return _BooksInLibrary;
    }

    public List<Book> removeBook(String author)
    {
        foreach(Book b in _BooksInLibrary)
        {
            if(b.Author == author)
            {
                _BooksInLibrary.Remove(b);
            }
        }
        return _BooksInLibrary;
    }

}



