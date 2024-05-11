namespace gerenciadorlivrariacsharp.Entity;

public class BookEntity
{
    public enum GenderType
    {
        Unknown,
        Aventura,
        Documentario,
        Ficcao,
        Misterio,
        Romance
    }

    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public GenderType Gender { get; set; } = GenderType.Unknown;
    public float Price { get; set; }
}
