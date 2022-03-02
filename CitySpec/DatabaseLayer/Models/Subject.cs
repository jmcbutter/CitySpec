namespace CitySpec.DatabaseLayer.Models;

public class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<Specification> Specifications { get; set; }
}