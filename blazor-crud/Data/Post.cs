using System.ComponentModel.DataAnnotations;

namespace blazor_crud.Data;

internal sealed class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Chasis { get; set; } = string.Empty;

    [Required]
    public string Marca { get; set; } = string.Empty;

    [Required]
    public string Modelo { get; set; } = string.Empty;

    [Required]
    public string Color { get; set; } = string.Empty;

    [Required]
    public string Year { get; set; } = string.Empty;

    [Required]
    public string Comentario { get; set; } = string.Empty;

    [Required]
    public string Foto { get; set; } = string.Empty;
}

