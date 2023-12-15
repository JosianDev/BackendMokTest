using System.Collections.Generic;
using System.Linq;
using BackenMokTest.Models;

namespace BackenMokTest.Services
{
    public class BookService : IBookService
    {
        private readonly BibliotecaBackContext _context;

        public BookService(BibliotecaBackContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBook(int id)
        {
            return _context.Books.Find(id);
        }

        public Book CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }

        public Book UpdateBook(int id, Book book)
        {
            var existingBook = _context.Books.Find(id);
            if (existingBook == null)
            {
                return null;
            }

            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Genre = book.Genre;
            existingBook.PublishDate = book.PublishDate;

            _context.SaveChanges();
            return existingBook;
        }

        public Book DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return null;
            }

            _context.Books.Remove(book);
            _context.SaveChanges();
            return book;
        }
    }
}
