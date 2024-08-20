using SevSport.DAL.Entities;

namespace SevSport.DAL.Entities.SportClothingAggregate;

public class Category : SEOEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public List<SportClothing> SportClothings { get; set; } = [];
}