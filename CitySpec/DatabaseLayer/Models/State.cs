namespace CitySpec.DatabaseLayer.EFModels;

public class State
{
    public int StateId { get; set; }

    public string StateName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<City> Cities { get; set; }
}