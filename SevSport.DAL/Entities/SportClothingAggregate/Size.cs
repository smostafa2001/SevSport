namespace SevSport.DAL.Entities.SportClothingAggregate;

public class Size
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<SportClothingSize> Clothes { get; set; } = [];
}