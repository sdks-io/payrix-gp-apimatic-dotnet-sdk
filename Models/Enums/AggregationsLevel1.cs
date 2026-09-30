using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The level of user that this aggregation will run for.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>admin</c> - <b>Admin User.</b></description></item>
///   <item><description><c>division</c> - <b>Division-level User.</b></description></item>
///   <item><description><c>merchant</c> - <b>Merchant-level User.</b></description></item>
///   <item><description><c>partition</c> - <b>Partition-level User.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggregationsLevel1>))]
public sealed record AggregationsLevel1 : OpenStringEnum<AggregationsLevel1>
{
    private AggregationsLevel1(string value) : base(value)
    {
    }

    public static readonly AggregationsLevel1 Admin = new("admin");

    public static readonly AggregationsLevel1 Division = new("division");

    public static readonly AggregationsLevel1 Merchant = new("merchant");

    public static readonly AggregationsLevel1 Partition = new("partition");

    public TResult Match<TResult>(Func<TResult> onAdmin,
        Func<TResult> onDivision,
        Func<TResult> onMerchant,
        Func<TResult> onPartition,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Admin => onAdmin(),
            _ when this == Division => onDivision(),
            _ when this == Merchant => onMerchant(),
            _ when this == Partition => onPartition(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdmin,
        Action onDivision,
        Action onMerchant,
        Action onPartition,
        Action<string> otherwise)
    {
        if (this == Admin) onAdmin();
        else if (this == Division) onDivision();
        else if (this == Merchant) onMerchant();
        else if (this == Partition) onPartition();
        else otherwise(Value);
    }
}
