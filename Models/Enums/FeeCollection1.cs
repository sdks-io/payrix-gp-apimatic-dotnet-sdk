using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Applies the fee based on the volume of a resource.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Txn.</b> The total amount of all transactions.</description></item>
///   <item><description><c>2</c> - <b>Txn-TaxID.</b> The total amount of all transactions per entity EIN/tax ID.</description></item>
///   <item><description><c>3</c> - <b>Txn-Merchant.</b> The total amount of all transactions per entity.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<FeeCollection1>))]
public sealed record FeeCollection1 : OpenIntEnum<FeeCollection1>
{
    private FeeCollection1(long value) : base(value)
    {
    }

    public static readonly FeeCollection1 Value1 = new(1L);

    public static readonly FeeCollection1 Value2 = new(2L);

    public static readonly FeeCollection1 Value3 = new(3L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action onValue2, Action onValue3, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else otherwise(Value);
    }
}
