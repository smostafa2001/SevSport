namespace SevSport.DAL.Entities;

public class EntityWithSoftDelete : EntityBase
{
    public bool IsRemoved { get; set; }
}