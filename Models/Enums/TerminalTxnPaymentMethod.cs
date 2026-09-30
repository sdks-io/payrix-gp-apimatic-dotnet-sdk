using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(IntEnumConverter<TerminalTxnPaymentMethod>))]
public sealed record TerminalTxnPaymentMethod : OpenIntEnum<TerminalTxnPaymentMethod>
{
    private TerminalTxnPaymentMethod(long value) : base(value)
    {
    }

    public static readonly TerminalTxnPaymentMethod Value0 = new(0L);

    public static readonly TerminalTxnPaymentMethod Value1 = new(1L);

    public static readonly TerminalTxnPaymentMethod Value2 = new(2L);

    public static readonly TerminalTxnPaymentMethod Value3 = new(3L);

    public static readonly TerminalTxnPaymentMethod Value4 = new(4L);

    public static readonly TerminalTxnPaymentMethod Value5 = new(5L);

    public static readonly TerminalTxnPaymentMethod Value7 = new(7L);

    public static readonly TerminalTxnPaymentMethod Value8 = new(8L);

    public static readonly TerminalTxnPaymentMethod Value9 = new(9L);

    public static readonly TerminalTxnPaymentMethod Value10 = new(10L);

    public static readonly TerminalTxnPaymentMethod Value11 = new(11L);

    public static readonly TerminalTxnPaymentMethod Value15 = new(15L);

    public static readonly TerminalTxnPaymentMethod Value16 = new(16L);

    public static readonly TerminalTxnPaymentMethod Value17 = new(17L);

    public static readonly TerminalTxnPaymentMethod Value18 = new(18L);

    public static readonly TerminalTxnPaymentMethod Value19 = new(19L);

    public static readonly TerminalTxnPaymentMethod Value20 = new(20L);

    public static readonly TerminalTxnPaymentMethod Value21 = new(21L);

    public static readonly TerminalTxnPaymentMethod Value22 = new(22L);

    public static readonly TerminalTxnPaymentMethod Value23 = new(23L);

    public static readonly TerminalTxnPaymentMethod Value24 = new(24L);

    public static readonly TerminalTxnPaymentMethod Value25 = new(25L);

    public static readonly TerminalTxnPaymentMethod Value26 = new(26L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue7,
        Func<TResult> onValue8,
        Func<TResult> onValue9,
        Func<TResult> onValue10,
        Func<TResult> onValue11,
        Func<TResult> onValue15,
        Func<TResult> onValue16,
        Func<TResult> onValue17,
        Func<TResult> onValue18,
        Func<TResult> onValue19,
        Func<TResult> onValue20,
        Func<TResult> onValue21,
        Func<TResult> onValue22,
        Func<TResult> onValue23,
        Func<TResult> onValue24,
        Func<TResult> onValue25,
        Func<TResult> onValue26,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value7 => onValue7(),
            _ when this == Value8 => onValue8(),
            _ when this == Value9 => onValue9(),
            _ when this == Value10 => onValue10(),
            _ when this == Value11 => onValue11(),
            _ when this == Value15 => onValue15(),
            _ when this == Value16 => onValue16(),
            _ when this == Value17 => onValue17(),
            _ when this == Value18 => onValue18(),
            _ when this == Value19 => onValue19(),
            _ when this == Value20 => onValue20(),
            _ when this == Value21 => onValue21(),
            _ when this == Value22 => onValue22(),
            _ when this == Value23 => onValue23(),
            _ when this == Value24 => onValue24(),
            _ when this == Value25 => onValue25(),
            _ when this == Value26 => onValue26(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue7,
        Action onValue8,
        Action onValue9,
        Action onValue10,
        Action onValue11,
        Action onValue15,
        Action onValue16,
        Action onValue17,
        Action onValue18,
        Action onValue19,
        Action onValue20,
        Action onValue21,
        Action onValue22,
        Action onValue23,
        Action onValue24,
        Action onValue25,
        Action onValue26,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value7) onValue7();
        else if (this == Value8) onValue8();
        else if (this == Value9) onValue9();
        else if (this == Value10) onValue10();
        else if (this == Value11) onValue11();
        else if (this == Value15) onValue15();
        else if (this == Value16) onValue16();
        else if (this == Value17) onValue17();
        else if (this == Value18) onValue18();
        else if (this == Value19) onValue19();
        else if (this == Value20) onValue20();
        else if (this == Value21) onValue21();
        else if (this == Value22) onValue22();
        else if (this == Value23) onValue23();
        else if (this == Value24) onValue24();
        else if (this == Value25) onValue25();
        else if (this == Value26) onValue26();
        else otherwise(Value);
    }
}
