namespace CitySpec.Model;

public class City
{
    public int CityId { get; set; }

    public string CityName { get; set; }

    public int StateId { get; set; }

    
    //--------------RELATIONSHIPS---------------------------

    public State State { get; set; }
    public ICollection<Manual> Manuals { get; set; }
}