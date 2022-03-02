namespace CitySpec.DatabaseLayer.Models;

public class Area
{
    public int AreaId { get; set; }
    
    public string AreaName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<Filter> Filters { get; set; }
    public ICollection<Specification> Specifications { get; set; }
}