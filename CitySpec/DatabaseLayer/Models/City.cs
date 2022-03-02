namespace CitySpec.DatabaseLayer.EFModels;

public class City
{
    public int CityId { get; set; }

    public string CityName { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }

    public int StateId { get; set; }
    
    //--------------RELATIONSHIPS---------------------------

    public State State { get; set; }
    public ICollection<Manual> Manuals { get; set; }
}