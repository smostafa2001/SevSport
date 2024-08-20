using SevSport.DAL.Entities;

namespace SevSport.DAL.Entities.SportClothingAggregate;

public class SportClothingPicture : EntityWithPicture
{
    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();
}