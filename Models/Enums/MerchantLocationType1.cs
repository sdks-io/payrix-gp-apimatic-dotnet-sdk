using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Description of the type of address that the business operates at.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>77</c> - <b>Retail Storefront</b></description></item>
///   <item><description><c>78</c> - <b>Warehouse</b></description></item>
///   <item><description><c>79</c> - <b>Private Residence</b></description></item>
///   <item><description><c>80</c> - <b>Others</b></description></item>
///   <item><description><c>81</c> - <b>P. RES-PROF/Construction</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MerchantLocationType1>))]
public sealed record MerchantLocationType1 : OpenIntEnum<MerchantLocationType1>
{
    private MerchantLocationType1(long value) : base(value)
    {
    }

    public static readonly MerchantLocationType1 Value77 = new(77L);

    public static readonly MerchantLocationType1 Value78 = new(78L);

    public static readonly MerchantLocationType1 Value79 = new(79L);

    public static readonly MerchantLocationType1 Value80 = new(80L);

    public static readonly MerchantLocationType1 Value81 = new(81L);

    public TResult Match<TResult>(Func<TResult> onValue77,
        Func<TResult> onValue78,
        Func<TResult> onValue79,
        Func<TResult> onValue80,
        Func<TResult> onValue81,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value77 => onValue77(),
            _ when this == Value78 => onValue78(),
            _ when this == Value79 => onValue79(),
            _ when this == Value80 => onValue80(),
            _ when this == Value81 => onValue81(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue77,
        Action onValue78,
        Action onValue79,
        Action onValue80,
        Action onValue81,
        Action<long> otherwise)
    {
        if (this == Value77) onValue77();
        else if (this == Value78) onValue78();
        else if (this == Value79) onValue79();
        else if (this == Value80) onValue80();
        else if (this == Value81) onValue81();
        else otherwise(Value);
    }
}
