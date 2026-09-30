using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The action taken on the referenced Txn. Block, Hold, or Reserve it.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>NONE</b></description></item>
///   <item><description><c>1</c> - <b>Block.</b> Block the Transaction from proceeding. This returns an error.</description></item>
///   <item><description><c>3</c> - <b>Hold.</b> Hold the Transaction. It will not be captured until it is manually released.</description></item>
///   <item><description><c>4</c> - <b>Reserve</b> Reserve the Transaction. The funds for the transaction will not be released until the Transaction is manually reviewed.</description></item>
///   <item><description><c>5</c> - <b>LIMIT</b> Block current activity.</description></item>
///   <item><description><c>6</c> - <b>PASS</b> Passed decision(s).</description></item>
///   <item><description><c>8</c> - <b>POSTREVIEWONLY</b> Passed decision(s).</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<HoldAction1>))]
public sealed record HoldAction1 : OpenIntEnum<HoldAction1>
{
    private HoldAction1(long value) : base(value)
    {
    }

    public static readonly HoldAction1 Value0 = new(0L);

    public static readonly HoldAction1 Value1 = new(1L);

    public static readonly HoldAction1 Value3 = new(3L);

    public static readonly HoldAction1 Value4 = new(4L);

    public static readonly HoldAction1 Value5 = new(5L);

    public static readonly HoldAction1 Value6 = new(6L);

    public static readonly HoldAction1 Value8 = new(8L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue8,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value8 => onValue8(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue8,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value8) onValue8();
        else otherwise(Value);
    }
}
