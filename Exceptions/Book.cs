

namespace GenericTaskCodeAcademy.Exceptions
{
    public class Book:Product
    {

        public int PageCount { get; set; }
        public string AuthorName { get; set; }

        public Book(string name, decimal price, string authorName, int pageCount,int count) : base(name,price)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count = Count;
        }
        public override void Sell()
        {
            if(Count == 0)
            {
                throw new ProductCountIsZeroException("Satis bas vermir");
            }
            Count--;
            TotalInCome+=Price;
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
