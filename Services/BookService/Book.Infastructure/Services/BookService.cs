using Book.Domain.Models;
using Book.Domain.Services;

namespace Book.Infastructure.Services
{
    public class BookService : IBookService
    {
        public BookDTO GetBookByISBN(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                return null;
            }
            var book = new BookDTO
            {
                Author = "J.R.R Tolkien",
                ISBN = isbn,
                PageCount = 1012,
                PublisherName = "Metis Yayınevi",
                Title = "Yüzüklerin Efendisi Tek Cilt Özel Basım"
            };
            var book1 = new BookDTO
            {
                Author = "Reşat Nuri Gültekin",
                ISBN = isbn,
                PageCount = 1012,
                PublisherName = "Ankara Yayınevi",
                Title = "Yaprak Dökümü"
            };
            return book;
        }
    }
}
