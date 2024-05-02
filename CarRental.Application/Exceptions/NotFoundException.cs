namespace CarRental.Application.Exceptions;

public class NotFoundException : Exception
{
    private string message { get; }

    public NotFoundException(string message)
        : base(message)
    {
        this.message = message;
    }
}
