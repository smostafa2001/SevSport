namespace SevSport.DAL.Entities.SportClothingAggregate;

public class Color
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string RGBAHex { get; set; } = string.Empty;

    public List<SportClothingColor> SportClothes { get; set; } = [];
}
