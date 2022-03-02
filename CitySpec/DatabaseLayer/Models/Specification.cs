namespace CitySpec.DatabaseLayer.Models;

public class Specification
{
    public int SpecificationId { get; set; }
    
    public string SpecificationSection { get; set; }
    public string SpecificationText { get; set; }
    
    public int ManualId { get; set; }
    public int AreaId { get; set; }
    public int SubjectId { get; set; }
    public int FilterId { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public Manual Manual { get; set; }
    public Area Area { get; set; }
    public Subject Subject { get; set; }
    public Filter Filter { get; set; }
}