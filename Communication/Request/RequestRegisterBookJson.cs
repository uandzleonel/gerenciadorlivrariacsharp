using System.ComponentModel.DataAnnotations;

namespace gerenciadorlivrariacsharp.Communication.Request;

public class RequestRegisterBookJson
{
    [Required]
    public string title { get; set; } = string.Empty;
    [Required]
    public string author { get; set; } = string.Empty;
    public string gender { get; set; } = string.Empty;
    public float price { get; set; }
}
