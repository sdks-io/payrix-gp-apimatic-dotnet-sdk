using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The current status of this Disbursement
/// &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Requested.</b> The request for this Disbursement has been received.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>2</c> - <b>Processing.</b> This Disbursement is being processed to be paid out.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>3</c> - <b>Processed.</b> This Disbursement has been paid by ACH to the bank account referenced in the Disbursement data.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>4</c> - <b>Failed.</b> A problem occurred and the payment processor has failed to process this Disbursement.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>6</c> - <b>Returned.</b> This Disbursement has been returned.</description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<DisbursementStatus1>))]
public sealed record DisbursementStatus1 : OpenIntEnum<DisbursementStatus1>
{
    private DisbursementStatus1(long value) : base(value)
    {
    }

    public static readonly DisbursementStatus1 Value1 = new(1L);

    public static readonly DisbursementStatus1 Value2 = new(2L);

    public static readonly DisbursementStatus1 Value3 = new(3L);

    public static readonly DisbursementStatus1 Value4 = new(4L);

    public static readonly DisbursementStatus1 Value5 = new(5L);

    public static readonly DisbursementStatus1 Value6 = new(6L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else otherwise(Value);
    }
}
