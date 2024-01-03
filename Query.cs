using HotChocolate.Types;

namespace Demo.GraphQL
{
    //Resolvers
    public class Query
    {
        public string Hello(string name = "World") => $"Hello {name}!";

        [UsePaging]
        public IEnumerable<Book> GetBooks() =>
        new Book[]
        {
            new Book("1984", "George Orwell", 19.99m),
            new Book("To Kill a Mockingbird", "Harper Lee", 24.99m),
            new Book("The Great Gatsby", "F. Scott Fitzgerald", 14.99m),
            new Book("Pride and Prejudice", "Jane Austen", 22.99m),
            new Book("The Catcher in the Rye", "J.D. Salinger", 17.99m),
            new Book("One Hundred Years of Solitude", "Gabriel Garcia Marquez", 29.99m),
            new Book("Moby-Dick", "Herman Melville", 27.99m),
            new Book("The Lord of the Rings", "J.R.R. Tolkien", 49.99m),
            new Book("Jane Eyre", "Charlotte Brontë", 21.99m),
        };
    }

    public record Book(string Title, string Author, decimal Price);
}
