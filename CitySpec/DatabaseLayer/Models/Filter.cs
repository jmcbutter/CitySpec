namespace CitySpec.DatabaseLayer.EFModels;

public class Filter
{
    public int FilterId { get; set; }
    
    public string FilterName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<Specification> Specifications { get; set; }
}