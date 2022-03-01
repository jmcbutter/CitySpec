namespace CitySpec.Model;

public class Manual
{
    public int ManualId { get; set; }
    
    public string ManualName { get; set; }
    public string PublicationYear { get; set; }
    
    public int CityId { get; set; }
    
    public City City { get; set; }
}