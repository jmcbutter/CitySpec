namespace CitySpec.Model;

public class AreaFilter
{
    public int AreaId { get; set; }
    public int FilterId { get; set; }
    
    public Area Area { get; set; }
    public Filter Filter { get; set; }
}