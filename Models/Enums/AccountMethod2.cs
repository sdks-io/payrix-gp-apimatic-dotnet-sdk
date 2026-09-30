using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of the Account.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>8</c> - <b>Checking</b></description></item>
///   <item><description><c>9</c> - <b>Savings</b></description></item>
///   <item><description><c>10</c> - <b>Corporate Checking</b></description></item>
///   <item><description><c>11</c> - <b>Corporate Savings</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<AccountMethod2>))]
public sealed record AccountMethod2 : OpenIntEnum<AccountMethod2>
{
    private AccountMethod2(long value) : base(value)
    {
    }

    public static readonly AccountMethod2 Value8 = new(8L);

    public static readonly AccountMethod2 Value9 = new(9L);

    public static readonly AccountMethod2 Value10 = new(10L);

    public static readonly AccountMethod2 Value11 = new(11L);

    public TResult Match<TResult>(Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue11,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value11 => onValue11(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue8, Action onValue9, Action onValue10, Action onValue11, Action<long> otherwise)
    {
        if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value11) onValue11();
        else otherwise(Value);
    }
}
