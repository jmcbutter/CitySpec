namespace CitySpec.Model;

public class ManualFilter
{
    public int ManualId { get; set; }
    public int FilterId { get; set; }
    
    public Manual Manual { get; set; }
    public Filter Filter { get; set; }
}