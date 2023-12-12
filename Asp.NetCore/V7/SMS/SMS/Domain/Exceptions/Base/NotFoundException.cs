namespace Domain.Exceptions.Base;

public class NotFoundException : Exception
{
    public NotFoundException(string exception)
    {
        Console.WriteLine(exception);
    }
}
