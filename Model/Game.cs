using System.ComponentModel.DataAnnotations;
namespace razor_ef_2022.Model;

public class Game
{
    public int GameId { get; set; }
    public string? Title { get; set; }
    public decimal Price { get; set; } = 5.99M;

    [DataType(DataType.Date)]
    public DateTime DatePublished { get; set; }
    public string? Genre { get; set; }
}