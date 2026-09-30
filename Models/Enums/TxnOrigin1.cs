using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The origin of the transaction.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Unknown.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Originated at a credit card terminal.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>2</c> - <b>Originated through an eCommerce system.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>3</c> - <b>Originated as a mail order or telephone order transaction.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>4</c> - <b>Originated with Apple Pay.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>5</c> - <b>Originated as a Successful 3D Secure transaction.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>6</c> - <b>Originated as an Attempted 3D Secure transaction.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>7</c> - <b>Deprecated. Originated as a recurring transaction on a card.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>8</c> - <b>Originated in a PayFrame.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>9</c> - <b>Originated in writing.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TxnOrigin1>))]
public sealed record TxnOrigin1 : OpenIntEnum<TxnOrigin1>
{
    private TxnOrigin1(long value) : base(value)
    {
    }

    public static readonly TxnOrigin1 Value0 = new(0L);

    public static readonly TxnOrigin1 Value1 = new(1L);

    public static readonly TxnOrigin1 Value2 = new(2L);

    public static readonly TxnOrigin1 Value3 = new(3L);

    public static readonly TxnOrigin1 Value4 = new(4L);

    public static readonly TxnOrigin1 Value5 = new(5L);

    public static readonly TxnOrigin1 Value6 = new(6L);

    public static readonly TxnOrigin1 Value7 = new(7L);

    public static readonly TxnOrigin1 Value8 = new(8L);

    public static readonly TxnOrigin1 Value9 = new(9L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
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
            _ when this == Value0 => onValue0(),
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

    public void Match(Action onValue0,
        Action onValue1,
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
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
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
