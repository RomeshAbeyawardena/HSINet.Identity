public interface IMeta
{
    string? Name { get; }
    string? Value { get; }
}

public class Meta : IMeta
{
    public string? Name { get; set; }
    public string? Value { get; set; }
}