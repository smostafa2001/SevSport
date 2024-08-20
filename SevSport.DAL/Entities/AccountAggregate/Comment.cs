using SevSport.DAL.Entities;
using SevSport.DAL.Entities.SportClothingAggregate;

namespace SevSport.DAL.Entities.AccountAggregate;

public class Comment : EntityBase
{
    public string Text { get; set; } = string.Empty;
    public bool IsConfirmed { get; set; }
    public bool IsCanceled { get; set; }

    public long SportClothingId { get; set; }
    public SportClothing SportClothing { get; set; } = new();

    public long UserId { get; set; }
    public User User { get; set; } = new();

    public long? ReplyToId { get; set; }
    public Comment? ReplyTo { get; set; }

    public List<Comment> Replies { get; set; } = [];
    public List<Liked> Likes { get; set; } = [];
}