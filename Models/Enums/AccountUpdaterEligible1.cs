using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates whether this resource is eligible to be sent for updates to wordpay as part of the account updater process.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Eligible</b></description></item>
///   <item><description><c>0</c> - <b>Not Eligible</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<AccountUpdaterEligible1>))]
public sealed record AccountUpdaterEligible1 : OpenIntEnum<AccountUpdaterEligible1>
{
    private AccountUpdaterEligible1(long value) : base(value)
    {
    }

    public static readonly AccountUpdaterEligible1 Value1 = new(1L);

    public static readonly AccountUpdaterEligible1 Value0 = new(0L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<TResult> onValue0, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value0 => onValue0(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue0, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value0) onValue0();
        else otherwise(Value);
    }
}
