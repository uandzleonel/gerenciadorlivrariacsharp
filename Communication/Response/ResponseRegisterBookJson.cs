namespace gerenciadorlivrariacsharp.Communication.Response;

public class ResponseRegisterBookJson
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Gender { get; set; }
    public float Price { get; set; }
}
