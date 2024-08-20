using SevSport.DAL.Entities;

namespace SevSport.DAL.Entities.SlideAggregate;
public class Slide : EntityWithPicture
{
    public string Heading { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string BtnText { get; set; } = string.Empty;
    public string Link { get; set; } = string.Empty;
}