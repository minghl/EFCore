using System.Linq;
namespace EFCore;

class Program
{
    static async Task Main(string[] args)
    {
        // ctx逻辑数据库
        using (MyDbContext ctx = new MyDbContext())
        {
            // Dog d = new Dog();
            // d.Name = "Trump";
            // 把对象加入到Dogs这个逻辑表里面
            // ctx.Dogs.Add(d);
            // update database
            // ctx.SaveChanges();
            // 异步方法save，能异步就异步
            // await ctx.SaveChangesAsync();

            // Book b1 = new Book { AuthorName = "John", Title = "JAVA", Price = 100, PutTime = new DateTime(2019, 3, 1) };
            // Book b2 = new Book { AuthorName = "Linda", Title = "C#", Price = 150, PutTime = new DateTime(2019, 3, 15) };
            // Book b3 = new Book { AuthorName = "Elisa", Title = "JS", Price = 98, PutTime = new DateTime(2020, 3, 1) };
            // Book b4 = new Book { AuthorName = "David", Title = "CPP", Price = 200, PutTime = new DateTime(2020, 5, 1) };
            // Book b5 = new Book { AuthorName = "Alex", Title = "Python", Price = 130, PutTime = new DateTime(2021, 10, 1) };
            // ctx.Books.Add(b1);
            // ctx.Books.Add(b2);
            // ctx.Books.Add(b3);
            // ctx.Books.Add(b4);
            // ctx.Books.Add(b5);
            // await ctx.SaveChangesAsync();

            // IQueryable<Book> books = ctx.Books.Where(b => b.Price > 100);

            // foreach (var book in books)
            // {
            //     Console.WriteLine(book.Title);
            // }

            // var book = ctx.Books.Single(b => b.Title == "CPP");
            // Console.WriteLine(book.AuthorName);

            // var books = ctx.Books.OrderBy(b => b.Price);
            // foreach (var book in books)
            // {
            //     Console.WriteLine(book.Title + "" + book.Price);
            // }
            // await ctx.SaveChangesAsync();

            // var items = ctx.Books.GroupBy(b => b.AuthorName).Select(g => new { Name = g.Key, BooksCount = g.Count(), MaxPrice = g.Max(b => b.Price) });
            // foreach (var item in items)
            // {
            //     System.Console.WriteLine(item.Name + item.BooksCount + item.MaxPrice + "");
            // }

            var b = ctx.Books.Single(b => b.Title == "CPP");
            b.AuthorName = "Junwu";
            var d = ctx.Dogs.Single(b => b.Id == 1);
            ctx.Dogs.Remove(d);
            await ctx.SaveChangesAsync();

        }
    }
}
