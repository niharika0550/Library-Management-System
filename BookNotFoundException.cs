using System;

namespace LMS
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(int bookId)
            : base($"Book with ID {bookId} was not found.")
        {
        }
    }
}