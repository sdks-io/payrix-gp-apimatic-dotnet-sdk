using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntitiesEinType>))]
public sealed record EntitiesEinType : OpenStringEnum<EntitiesEinType>
{
    private EntitiesEinType(string value) : base(value)
    {
    }

    public static readonly EntitiesEinType Ssn = new("ssn");

    public static readonly EntitiesEinType Tin = new("tin");

    public static readonly EntitiesEinType Other = new("other");

    public TResult Match<TResult>(Func<TResult> onSsn,
        Func<TResult> onTin,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ssn => onSsn(),
            _ when this == Tin => onTin(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onSsn, Action onTin, Action onOther, Action<string> otherwise)
    {
        if (this == Ssn) onSsn();
        else if (this == Tin) onTin();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
