using SevSport.DAL.Entities;
using SevSport.DAL.Entities.OrderAggregate;

namespace SevSport.DAL.Entities.AccountAggregate;

public class User : EntityBase
{
    public string Fullname { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string? Mobile { get; set; }
    public string? Email { get; set; }
    public string ProfilePhoto { get; set; } = string.Empty;
    public long PostalCode { get; set; }

    public List<Address> Addresses { get; set; } = [];
    public List<Comment> Comments { get; set; } = [];
    public List<Liked> LikedComments { get; set; } = [];
    public List<Order> Orders { get; set; } = [];
}