using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this txnResult is the type of this txnResult.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c>  -  <b>A general type of result.</b></description></item>
///   <item><description><c>2</c>  -  <b>Fraud prevention alert.</b></description></item>
///   <item><description><c>3</c>  -  <b>Processor error.</b></description></item>
///   <item><description><c>4</c>  -  <b>CVV matching alert.</b></description></item>
///   <item><description><c>5</c>  -  <b>AVS check alert.</b></description></item>
///   <item><description><c>6</c>  -  <b>AAVS check alert.</b></description></item>
///   <item><description><c>7</c>  -  <b>Network error.</b></description></item>
///   <item><description><c>8</c>  -  <b>3DS check alert.</b></description></item>
///   <item><description><c>9</c>  -  <b>Pinless Debit conversion failed attempt.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnResultType2>))]
public sealed record TxnResultType2 : OpenIntEnum<TxnResultType2>
{
    private TxnResultType2(long value) : base(value)
    {
    }

    public static readonly TxnResultType2 Value1 = new(1L);

    public static readonly TxnResultType2 Value2 = new(2L);

    public static readonly TxnResultType2 Value3 = new(3L);

    public static readonly TxnResultType2 Value4 = new(4L);

    public static readonly TxnResultType2 Value5 = new(5L);

    public static readonly TxnResultType2 Value6 = new(6L);

    public static readonly TxnResultType2 Value7 = new(7L);

    public static readonly TxnResultType2 Value8 = new(8L);

    public static readonly TxnResultType2 Value9 = new(9L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else otherwise(Value);
    }
}
