using SevSport.DAL.AccountAggregate;
using SevSport.DAL.Entities.OrderAggregate;

namespace SevSport.DAL.Entities.InventoryAggregate;

public class InventoryOperation
{
    public long Id { get; set; }
    public bool Operation { get; set; }
    public int Count { get; set; }
    public DateTime OperationDate { get; set; }
    public int CurrentStock { get; set; }
    public string Description { get; set; } = string.Empty;

    public long? OrderId { get; set; }
    public Order? Order { get; set; }

    public long InventoryId { get; set; }
    public Inventory Inventory { get; set; } = new();
}