namespace gerenciadorlivrariacsharp.Entity;

public static class BookListEntity
{

    public static Dictionary<Guid, BookEntity> books = [];
    public static Guid Add(BookEntity book)
    {
        Guid Id = Guid.NewGuid();
        books.Add(Id, book);

        return Id;
    }
    public static void Update(Guid Id, BookEntity book)
    {
        books.Remove(Id);
        books.Add(Id, book);
    }

    public static void Delete(Guid id)
    {
        books.Remove(id);
    }
}
