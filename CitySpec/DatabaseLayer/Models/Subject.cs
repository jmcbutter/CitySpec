namespace CitySpec.DatabaseLayer.EFModels;

public class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; }
    
    //--------------RELATIONSHIPS---------------------------
    
    public ICollection<Specification> Specifications { get; set; }
}