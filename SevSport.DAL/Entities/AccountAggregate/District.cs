namespace SevSport.DAL.Entities.AccountAggregate;

public class District
{
    public short Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public byte ProvinceId { get; set; }
    public Province Province { get; set; } = new();
}