

namespace GenericTaskCodeAcademy.Exceptions
{
    public class Book:Product
    {

        public int PageCount { get; set; }
        public string AuthorName { get; set; }

        public Book(string name, decimal price, string authorName, int pageCount,int count) : base(name,price)
        {
            
            AuthorName = authorName;
            PageCount = pageCount;
            Count = count;
        }
        public override void Sell()
        {
            if(Count >0)
            {

            Count--;
            TotalInCome+=Price;
            }
            else {
                throw new ProductCountIsZeroException("Satis bas vermir");
            }
            
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Author: {AuthorName}");
            Console.WriteLine($"Page Count: {PageCount}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine($"Total Income: {TotalInCome}");
        }
    }
}
