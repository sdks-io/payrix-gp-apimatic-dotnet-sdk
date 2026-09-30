using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates whether the Account is the primary Account for the associated Entity.
/// Only one Account associated with each Entity can be the primary Account.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not primary</b></description></item>
///   <item><description><c>1</c> - <b>Primary</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<AccountPrimary1>))]
public sealed record AccountPrimary1 : OpenIntEnum<AccountPrimary1>
{
    private AccountPrimary1(long value) : base(value)
    {
    }

    public static readonly AccountPrimary1 Value0 = new(0L);

    public static readonly AccountPrimary1 Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue0, Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
