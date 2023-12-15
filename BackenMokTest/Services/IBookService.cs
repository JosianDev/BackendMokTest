using System.Collections.Generic;
using BackenMokTest.Models;


namespace BackenMokTest.Services
{
    
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        Book CreateBook(Book book);
        Book UpdateBook(int id, Book book);
        Book DeleteBook(int id);
    }
}
