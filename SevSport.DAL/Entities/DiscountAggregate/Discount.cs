using SevSport.DAL.Entities;
using SevSport.DAL.Entities.SportClothingAggregate;

namespace SevSport.DAL.Entities.DiscountAggregate;

public class Discount : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public byte DiscountRate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public List<SportClothing> SportClothings { get; set; } = [];
}