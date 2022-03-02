namespace CitySpec.DatabaseLayer.EFModels;

public class Manual
{
    public int ManualId { get; set; }
    
    public string ManualName { get; set; }
    public string PublicationYear { get; set; }
    
    public int CityId { get; set; }
    
    //--------------RELATIONSHIPS---------------------------

    public City City { get; set; }
    public ICollection<Area> Areas { get; set; }
    public ICollection<Filter> Filters { get; set; }
    public ICollection<Subject> Subjects { get; set; }
    public ICollection<Specification> Specifications { get; set; }
}