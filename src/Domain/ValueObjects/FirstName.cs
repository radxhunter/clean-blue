namespace CleanArchitecture.Domain.ValueObjects;

public sealed class FirstName : ValueObject
{
    public FirstName()
    {

    }

    public const int MaxLength = 50;

    private FirstName(string value)
    {
       
        Value = value;
    }

    public static FirstName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException($"The {nameof(FirstName)} couldn't be empty");
        }

        if (value.Length > MaxLength)
        {
            throw new ArgumentException($"Max length of {nameof(FirstName)} is {MaxLength}");
        }

        return new FirstName(value);
    }

    public string Value { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
