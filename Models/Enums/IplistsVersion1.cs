using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether this IP List contains IPv4 addresses (for example, 198.51.100.113) or IPv6 addresses (for example, 2001:0db8:85a3:0000:0000:8a2e:0370:7334).
/// <para>
/// You can only use one type in each IP List resource.
/// </para>
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>4</c> - <b>IPv4 addresses.</b> (Example: 198.51.100.113)</description></item>
///   <item><description><c>6</c> - <b>IPv6 addresses.</b> (Example: 2001:0db8:85a3:0000:0000:8a2e:0370:7334)</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<IplistsVersion1>))]
public sealed record IplistsVersion1 : OpenIntEnum<IplistsVersion1>
{
    private IplistsVersion1(long value) : base(value)
    {
    }

    public static readonly IplistsVersion1 Value4 = new(4L);

    public static readonly IplistsVersion1 Value6 = new(6L);

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
