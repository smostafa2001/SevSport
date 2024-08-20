using SevSport.DAL.Entities;
using SevSport.DAL.Entities.SportClothingAggregate;

namespace SevSport.DAL.Entities.InventoryAggregate;
public class Inventory : EntityBase
{
    public int UnitPrice { get; set; }
    public bool IsInStock { get; set; }

    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();

    public List<InventoryOperation> InventoryOperations { get; set; } = [];
}