using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MembersGender>))]
public sealed record MembersGender : OpenStringEnum<MembersGender>
{
    private MembersGender(string value) : base(value)
    {
    }

    public static readonly MembersGender Male = new("male");

    public static readonly MembersGender Female = new("female");

    public TResult Match<TResult>(Func<TResult> onMale, Func<TResult> onFemale, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Male => onMale(),
            _ when this == Female => onFemale(),
            _ => otherwise(Value)
        };

    public void Match(Action onMale, Action onFemale, Action<string> otherwise)
    {
        if (this == Male) onMale();
        else if (this == Female) onFemale();
        else otherwise(Value);
    }
}
