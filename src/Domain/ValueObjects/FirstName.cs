using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.ValueObjects;
public class FirstName : ValueObject
{
    public const int MaxLength = 50;

    public FirstName()
    {

    }

    private FirstName(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static FirstName Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException($"The {nameof(FirstName)} couldn't be empty");
        }

        if (value.Length > MaxLength)
        {
            throw new FirstNameTooLongException(nameof(FirstName), MaxLength);
        }

        return new FirstName(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
