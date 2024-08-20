using SevSport.DAL.Entities;

namespace SevSport.DAL.Entities.SportClothingAggregate;

public class Material : EntityWithSoftDelete
{
    public string Name { get; set; } = string.Empty;

    public List<SportClothing> Clothes { get; set; } = [];
}