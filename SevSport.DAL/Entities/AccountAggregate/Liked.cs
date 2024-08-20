using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevSport.DAL.Entities.AccountAggregate;
public class Liked
{
    public long UserId { get; set; }
    public User User { get; set; } = new();

    public long CommentId { get; set; }
    public Comment Comment { get; set; } = new();

    public DateTime TimeToLike { get; set; }
}