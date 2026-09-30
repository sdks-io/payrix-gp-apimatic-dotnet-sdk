using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The origin of the Txn that will be created through this Subscription.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>2</c> - <b>Customer will be subscribing through eCommerce.</b></description></item>
///   <item><description><c>3</c> - <b>Customer will be subscribing by Mail Order/Telephone.</b></description></item>
///   <item><description><c>4</c> - <b>Originated with Apple Pay.</b></description></item>
///   <item><description><c>5</c> - <b>Originated as a Successful 3D Secure transaction.</b></description></item>
///   <item><description><c>6</c> - <b>Originated as an Attempted 3D Secure transaction.</b></description></item>
///   <item><description><c>8</c> - <b>Originated in a Payframe.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<SubscriptionOrigin1>))]
public sealed record SubscriptionOrigin1 : OpenIntEnum<SubscriptionOrigin1>
{
    private SubscriptionOrigin1(long value) : base(value)
    {
    }

    public static readonly SubscriptionOrigin1 Value2 = new(2L);

    public static readonly SubscriptionOrigin1 Value3 = new(3L);

    public static readonly SubscriptionOrigin1 Value4 = new(4L);

    public static readonly SubscriptionOrigin1 Value5 = new(5L);

    public static readonly SubscriptionOrigin1 Value6 = new(6L);

    public static readonly SubscriptionOrigin1 Value8 = new(8L);

    public TResult Match<TResult>(Func<TResult> onValue2,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue6,
        Func<TResult> onValue8,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value2 => onValue2(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value6 => onValue6(),
            _ when this == Value8 => onValue8(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue2,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue6,
        Action onValue8,
        Action<long> otherwise)
    {
        if (this == Value2) onValue2();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value6) onValue6();
        else if (this == Value8) onValue8();
        else otherwise(Value);
    }
}
