using SevSport.DAL.Entities;
using SevSport.DAL.Entities.AccountAggregate;

namespace SevSport.DAL.Entities.OrderAggregate;

public class Order : EntityBase
{
    public long TrackingId { get; set; }
    public long RefId { get; set; }
    public int TotalAmount { get; set; }
    public int DiscountAmount { get; set; }
    public int PayableAmount { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int FinalPrice { get; set; }
    public bool HasBeenSent { get; set; }
    public bool HasBeenReceived { get; set; }

    public long AddressId { get; set; }
    public Address Address { get; set; } = new();

    public long UserId { get; set; }
    public User User { get; set; } = new();

    public List<OrderItem> OrderItems { get; set; } = [];
}