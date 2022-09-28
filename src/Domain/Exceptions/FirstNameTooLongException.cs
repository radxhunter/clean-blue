namespace CleanArchitecture.Domain.Exceptions;

public class FirstNameTooLongException : Exception
{
    public FirstNameTooLongException(string name, int maxLength)
        : base($"Max length of {name} is {maxLength}")
    {

    }
}
