using SevSport.DAL.Entities;
using SevSport.DAL.Entities.SportClothingAggregate;

namespace SevSport.DAL.Entities.OrderAggregate;

public class OrderItem : EntityBase
{
    public int Count { get; set; }
    public int UnitPrice { get; set; }
    public byte DiscountRate { get; set; }

    public long OrderId { get; set; }
    public Order Order { get; set; } = new();

    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();
}