using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether the Payout resource will be marked to skip the creation of disbursements on holidays and weekends.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Do not skip Holidays and Weekends.</b> Disbursement will be generated in a Requested status and process the next business day.</description></item>
///   <item><description><c>1</c> - <b>Skip Holidays and Weekends.</b> IMPORTANT: We do not advise setting this for weekly, monthly, or yearly Payout schedules as the disbursement will skip and not be generated until the next scheduled date.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<PayoutFlowsSkipOffDays1>))]
public sealed record PayoutFlowsSkipOffDays1 : OpenIntEnum<PayoutFlowsSkipOffDays1>
{
    private PayoutFlowsSkipOffDays1(long value) : base(value)
    {
    }

    public static readonly PayoutFlowsSkipOffDays1 Value0 = new(0L);

    public static readonly PayoutFlowsSkipOffDays1 Value1 = new(1L);

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
