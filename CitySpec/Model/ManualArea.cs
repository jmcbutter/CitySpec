namespace CitySpec.Model;

public class ManualArea
{
    public int ManualId { get; set; }
    public int AreaId { get; set; }
    
    public Manual Manual { get; set; }
    public Area Area { get; set; }
}