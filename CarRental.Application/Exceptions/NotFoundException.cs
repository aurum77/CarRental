using CarRental.Application.Exceptions.Attributes;

namespace CarRental.Application.Exceptions;

[CustomException]
public class NotFoundException : Exception
{
    private string message { get; }

    public NotFoundException(string message)
        : base(message)
    {
        this.message = message;
    }
}
