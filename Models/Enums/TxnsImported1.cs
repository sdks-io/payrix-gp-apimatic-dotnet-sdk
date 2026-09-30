using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether the txn was imported from a report or not, this field is set automatically whether the txn was imported from a report or not. This field is set automatically.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <para>
/// - <c>0</c>  - <b>Not Imported</b>
/// - <c>1</c>  - <b>Imported</b>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnsImported1>))]
public sealed record TxnsImported1 : OpenIntEnum<TxnsImported1>
{
    private TxnsImported1(long value) : base(value)
    {
    }

    public static readonly TxnsImported1 Value0 = new(0L);

    public static readonly TxnsImported1 Value1 = new(1L);

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
