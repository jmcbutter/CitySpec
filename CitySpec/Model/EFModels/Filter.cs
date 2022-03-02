namespace CitySpec.Model;

public class Filter
{
    public int FilterId { get; set; }
    
    public string FilterName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<Specification> Specifications { get; set; }
}