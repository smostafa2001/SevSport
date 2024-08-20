using SevSport.DAL.Entities;

namespace SevSport.DAL.Entities.AccountAggregate;

public class Address : EntityBase
{
    public string Title { get; set; } = string.Empty;
    public string MainAddress { get; set; } = string.Empty;

    public byte ProvinceId { get; set; }
    public Province Province { get; set; } = new();

    public short DistrictId { get; set; }
    public District District { get; set; } = new();

    public long UserId { get; set; }
    public User User { get; set; } = new();
}