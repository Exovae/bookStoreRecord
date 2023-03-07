using System;

public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Bookstore book1 = new Bookstore(1, "The Catcher in the Rye", "J.D. Salinger", 10.99);
        Bookstore book2 = new Bookstore(2, "To Kill a Mockingbird", "Harper Lee", 12.99);
        Bookstore book3 = new Bookstore(3, "1984", "George Orwell", 8.99);

        Console.WriteLine("Book 1: ID-{0}, Title-{1}, Author-{2}, Price-{3:C}", book1.ID, book1.Title, book1.Author, book1.Price);
        Console.WriteLine("Book 2: ID-{0}, Title-{1}, Author-{2}, Price-{3:C}", book2.ID, book2.Title, book2.Author, book2.Price);
        Console.WriteLine("Book 3: ID-{0}, Title-{1}, Author-{2}, Price-{3:C}", book3.ID, book3.Title, book3.Author, book3.Price);
    }
}
