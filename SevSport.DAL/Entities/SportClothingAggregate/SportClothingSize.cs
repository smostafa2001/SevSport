namespace SevSport.DAL.Entities.SportClothingAggregate;

public class SportClothingSize
{
    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();

    public long SizeId { get; set; }
    public Size Size { get; set; } = new();
}