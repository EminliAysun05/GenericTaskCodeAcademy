using GenericTaskCodeAcademy.Exceptions;

namespace GenericTaskCodeAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Library library = new Library(3);
                Book book1 = new Book("Book1", 15, "Author one", 500, 5);
                Book book2 = new Book("Book2", 40, "Author two", 250, 45);
                Book book3 = new Book("Book3", 65, "Author three", 1200, 1);
                library.AddBook(book1);
                library.AddBook(book2);

                //All books
                Console.WriteLine("All books: ");
                foreach (var book in library.GetAllBook())
                {
                    book.ShowInfo();
                }
                //Remove book by id
                library.RemoveById(book1.Id);
                // get book by id
                var retrivedBook = library.GetBookById(book2.Id);
                Console.WriteLine("Selling book: ");
                retrivedBook.ShowInfo();
                //Selling book
                book2.Sell();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
