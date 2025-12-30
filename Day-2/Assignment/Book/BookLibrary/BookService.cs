using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary
{
    internal class BookService
    {

        List<Book> booklList = [];
        Dictionary<int, Book> dict = new Dictionary<int, Book>();


       
        internal bool addBook(Book book)
        {
            booklList.Add(book);

            dict.Add(book.Id, book);

            return true;
        }

        internal List<Book> getAllBooks()
        {
            return booklList;
        }

        internal Book getBookById(int id)
        {
            if (dict.ContainsKey(id))
            {
                return dict[id];
            }

            return null;
        }
    }
}