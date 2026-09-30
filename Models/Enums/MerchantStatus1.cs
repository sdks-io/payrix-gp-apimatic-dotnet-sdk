using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of the Merchant.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not ready</b>. Occurs when a new Merchant is created. Unable to process payments.</description></item>
///   <item><description><c>1</c> - <b>Ready</b>. New Merchant submitted for underwriting approval after submitting a signup form.</description></item>
///   <item><description><c>2</c> - <b>Boarded</b>. Merchant has been approved and boarded to the platform. Payment processing now available.</description></item>
///   <item><description><c>3</c> - <b>Manual</b>. Set internally by platform underwriting. New Merchant is pending manual verification.</description></item>
///   <item><description><c>4</c> - <b>Closed</b>. Set internally by platform underwriting. New Merchant was declined and cannot access the platform.</description></item>
///   <item><description><c>5</c> - <b>Incomplete</b>. Set by user boarding the merchant. Can be manually set to "save" an incomplete Merchant boarding request for a later time.</description></item>
///   <item><description><c>6</c> - <b>Pending</b>. New Merchant was submitted for boarding, platform access pending review.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MerchantStatus1>))]
public sealed record MerchantStatus1 : OpenIntEnum<MerchantStatus1>
{
    private MerchantStatus1(long value) : base(value)
    {
    }

    public static readonly MerchantStatus1 Value0 = new(0L);

    public static readonly MerchantStatus1 Value1 = new(1L);

    public static readonly MerchantStatus1 Value2 = new(2L);

    public static readonly MerchantStatus1 Value3 = new(3L);

    public static readonly MerchantStatus1 Value4 = new(4L);

    public static readonly MerchantStatus1 Value5 = new(5L);

    public static readonly MerchantStatus1 Value6 = new(6L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
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
            _ => otherwise(Value)
        };

    public void Match(Action onValue0,
        Action onValue1,
        Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else otherwise(Value);
    }
}
