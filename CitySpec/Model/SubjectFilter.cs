namespace CitySpec.Model;

public class SubjectFilter
{
    public int SubjectId { get; set; }
    public int FilterId { get; set; }

    public Subject Subject { get; set; }
    public Filter Filter { get; set; }
}