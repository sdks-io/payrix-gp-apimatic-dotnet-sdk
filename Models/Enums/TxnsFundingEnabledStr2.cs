using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether or not funding is enabled for this Transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Disabled.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Enabled.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnsFundingEnabledStr2>))]
public sealed record TxnsFundingEnabledStr2 : OpenStringEnum<TxnsFundingEnabledStr2>
{
    private TxnsFundingEnabledStr2(string value) : base(value)
    {
    }

    public static readonly TxnsFundingEnabledStr2 _0 = new("0");

    public static readonly TxnsFundingEnabledStr2 _1 = new("1");

    public TResult Match<TResult>(Func<TResult> on_0, Func<TResult> on_1, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else otherwise(Value);
    }
}
