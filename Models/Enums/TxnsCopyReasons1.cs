using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Reason for copying Transaction referenced in fromtxn field, which
/// can be either resubmission or reauthorization.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>resubmission</c> - <b>Resubmission.</b></description></item>
///   <item><description><c>reauthorization</c> - <b>Reauthorization.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TxnsCopyReasons1>))]
public sealed record TxnsCopyReasons1 : OpenStringEnum<TxnsCopyReasons1>
{
    private TxnsCopyReasons1(string value) : base(value)
    {
    }

    public static readonly TxnsCopyReasons1 Resubmission = new("resubmission");

    public static readonly TxnsCopyReasons1 Reauthorization = new("reauthorization");

    public TResult Match<TResult>(Func<TResult> onResubmission,
        Func<TResult> onReauthorization,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Resubmission => onResubmission(),
            _ when this == Reauthorization => onReauthorization(),
            _ => otherwise(Value)
        };

    public void Match(Action onResubmission, Action onReauthorization, Action<string> otherwise)
    {
        if (this == Resubmission) onResubmission();
        else if (this == Reauthorization) onReauthorization();
        else otherwise(Value);
    }
}
