using System.ComponentModel.DataAnnotations.Schema;
namespace AppRepositoryPatten.Entities.Models;

[Table("Ogrenci")]
public class Ogrenci
{
    public int Id { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
}

