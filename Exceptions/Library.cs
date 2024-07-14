

namespace GenericTaskCodeAcademy.Exceptions
{
    public class Library
    {
        public int BookLimit { get;  }
        private List<Book> Books { get;}
        public Library(int bookLimit)
        {
            if(bookLimit < 0)
            {
                throw new ArgumentOutOfRangeException("BookLimit 0'dan kicik ola bilmez");
            }
            Books = new List<Book>();
            BookLimit = bookLimit;
        }
        public void AddBook(Book book)
        {
            if(Books.Count>= BookLimit)
            {
                throw new CapacityLimitException("Capacity dolub");
            }
            Books.Add(book);
        }

        public Book GetBookById(int id)
        {
            foreach(Book book in Books)
            {
                if(book.Id == id) {  return book; }
                     
            }
            throw new NotFoundException("Kitab tapilmadi");
        }

        public List<Book> GetAllBook()
        {
            return new List<Book>(Books);
        }

        public void RemoveById(int id)
        {
            foreach (Book book in Books)
            {
                if( book.Id == id)
                {
                    Books.Remove(book);
                }
            }
            throw new NotFoundException("Silmek istediyiniz kitab tapilmadi");
        }
    }
}
