namespace SevSport.DAL.Entities.SportClothingAggregate;

public class SportClothingColor
{
    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();

    public long ColorId { get; set; }
    public Color Color { get; set; } = new();
}