namespace SevSport.DAL.Entities;

public class EntityWithPicture : EntityWithSoftDelete
{
    public string Picture { get; set; } = string.Empty;
    public string PictureAlt { get; set; } = string.Empty;
    public string PictureTitle { get; set; } = string.Empty;
}