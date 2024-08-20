using SevSport.DAL.Entities;
using SevSport.DAL.Entities.DiscountAggregate;

namespace SevSport.DAL.Entities.SportClothingAggregate;

public class SportClothing : SEOEntity
{
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsRemoved { get; set; }

    public long MaterialId { get; set; }
    public Material Material { get; set; } = new();

    public long DiscountId { get; set; }
    public Discount Discount { get; set; } = new();

    public long CategoryId { get; set; }
    public Category Category { get; set; } = new();

    public List<SportClothingPicture> Pictures { get; set; } = [];
    public List<SportClothingSize> Sizes { get; set; } = [];
    public List<SportClothingColor> Colors { get; set; } = [];
}