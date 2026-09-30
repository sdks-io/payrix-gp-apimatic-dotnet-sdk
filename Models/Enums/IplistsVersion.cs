using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<IplistsVersion>))]
public sealed record IplistsVersion : OpenIntEnum<IplistsVersion>
{
    private IplistsVersion(long value) : base(value)
    {
    }

    public static readonly IplistsVersion Value4 = new(4L);

    public static readonly IplistsVersion Value6 = new(6L);

    public TResult Match<TResult>(Func<TResult> onValue4, Func<TResult> onValue6, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value4 => onValue4(),
            _ when this == Value6 => onValue6(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue4, Action onValue6, Action<long> otherwise)
    {
        if (this == Value4) onValue4();
        else if (this == Value6) onValue6();
        else otherwise(Value);
    }
}
