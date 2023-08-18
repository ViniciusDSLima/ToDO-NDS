namespace Application.Exceptions;

public class ModelsExceptions : Exception
{
    public List<string> _errors;
    public IReadOnlyCollection<string> Errors => _errors;
    
    public ModelsExceptions(){}

    public ModelsExceptions(string message) : base(message)
    {
    }
    
    
    
}