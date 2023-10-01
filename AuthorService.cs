public class AuthorService : IAuthorService
{
    private readonly List<Author> _Authors;

    public AuthorService()
    {
        _Authors = new List<Author>
        {
            new Author { Id = 1, Title = "1984", Author = "George Orwell" },
            new Author { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
            new Author { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
        };
    }

    public IEnumerable<Author> GetAllAuthors() => _authors;

    public Author GetAuthorById(int id) => _authors.FirstOrDefault(a => a.Id == id);

    public void AddAuthor(Author author)
    {
        _authors.Add(author);
    }

    public void UpdateAuthor(Author author)
    {
        var existingAuthor = GetAuthorById(author.Id);
        if (existingAuthor == null)
        {
            return;
        }
        existingAuthor.Title = author.Title;
        existingAuthor.Author = author.Author;
    }

    public void DeleteAuthor(int id)
    {
        var author = GetAuthorById(id);
        if (author == null)
        {
            return;
        }
        _authors.Remove(author);
    }
}