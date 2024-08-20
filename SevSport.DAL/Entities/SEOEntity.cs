namespace SevSport.DAL.Entities;

public class SEOEntity : EntityBase
{
    public string Picture { get; set; } = string.Empty;
    public string PictureAlt { get; set; } = string.Empty;
    public string PictureTitle { get; set; } = string.Empty;
    public string Keywords { get; set; } = string.Empty;
    public string MetaDescription { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
}