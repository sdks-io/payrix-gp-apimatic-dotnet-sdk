using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Where the feeRule should apply.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>both</c> - <b>Both.</b> The rule should apply to the fee and to the calculation of collections.</description></item>
///   <item><description><c>fee</c> - <b>Fee.</b> The rule should apply only to the fee itself.</description></item>
///   <item><description><c>collection</c> - <b>Collection.</b> The fee should be only used when calculating a collection.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FeeApplication1>))]
public sealed record FeeApplication1 : OpenStringEnum<FeeApplication1>
{
    private FeeApplication1(string value) : base(value)
    {
    }

    public static readonly FeeApplication1 Both = new("both");

    public static readonly FeeApplication1 Fee = new("fee");

    public static readonly FeeApplication1 Collection = new("collection");

    public TResult Match<TResult>(Func<TResult> onBoth,
        Func<TResult> onFee,
        Func<TResult> onCollection,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Both => onBoth(),
            _ when this == Fee => onFee(),
            _ when this == Collection => onCollection(),
            _ => otherwise(Value)
        };

    public void Match(Action onBoth, Action onFee, Action onCollection, Action<string> otherwise)
    {
        if (this == Both) onBoth();
        else if (this == Fee) onFee();
        else if (this == Collection) onCollection();
        else otherwise(Value);
    }
}
