using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The action to take when this check fails.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Block txn, will never be processed. The Entity is sent to the manual review queue.</b></description></item>
///   <item><description><c>3</c> - <b>Hold txn, will not be captured.</b></description></item>
///   <item><description><c>4</c> - <b>Reserve txn, funds should be reserved.</b></description></item>
///   <item><description><c>5</c> - <b>Block current activity, no change for merchant.</b></description></item>
///   <item><description><c>8</c> - <b>We onboard the merchant and wait for manual check later.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<DescisionActionsAction1>))]
public sealed record DescisionActionsAction1 : OpenIntEnum<DescisionActionsAction1>
{
    private DescisionActionsAction1(long value) : base(value)
    {
    }

    public static readonly DescisionActionsAction1 Value1 = new(1L);

    public static readonly DescisionActionsAction1 Value3 = new(3L);

    public static readonly DescisionActionsAction1 Value4 = new(4L);

    public static readonly DescisionActionsAction1 Value5 = new(5L);

    public static readonly DescisionActionsAction1 Value8 = new(8L);

    public TResult Match<TResult>(Func<TResult> onValue1,
        Func<TResult> onValue3,
        Func<TResult> onValue4,
        Func<TResult> onValue5,
        Func<TResult> onValue8,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ when this == Value3 => onValue3(),
            _ when this == Value4 => onValue4(),
            _ when this == Value5 => onValue5(),
            _ when this == Value8 => onValue8(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1,
        Action onValue3,
        Action onValue4,
        Action onValue5,
        Action onValue8,
        Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else if (this == Value3) onValue3();
        else if (this == Value4) onValue4();
        else if (this == Value5) onValue5();
        else if (this == Value8) onValue8();
        else otherwise(Value);
    }
}
