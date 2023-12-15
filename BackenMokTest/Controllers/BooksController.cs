using BackenMokTest.Models;
using BackenMokTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BackenMokTest.Controllers
{
    [Route("api/books")]
    [ApiController]
    [Authorize] 
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            try
            {
                var books = _bookService.GetBooks();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error al recuperar libros: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            try
            {
                var book = _bookService.GetBook(id);
                if (book == null)
                {
                    return NotFound();
                }
                return Ok(book);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error al recuperar libro: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book)
        {
            try
            {
                var createdBook = _bookService.CreateBook(book);
                return CreatedAtAction(nameof(GetBook), new { id = createdBook.BookId }, createdBook);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error al crear libro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] Book book)
        {
            try
            {
                var updatedBook = _bookService.UpdateBook(id, book);
                if (updatedBook == null)
                {
                    return NotFound();
                }
                return Ok(updatedBook);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error al actualizar libro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                var deletedBook = _bookService.DeleteBook(id);
                if (deletedBook == null)
                {
                    return NotFound();
                }
                return Ok(deletedBook);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error al eliminar libro: {ex.Message}");
            }
        }
    }
}
