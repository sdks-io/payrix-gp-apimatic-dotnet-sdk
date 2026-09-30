using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates whether the Account Updater is enabled and states which platform it will use to send the payment update files.
/// The default setting is 0 (Not Enabled)
/// <para>
///   &lt;details&gt;
///   &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Not Enabled</b></description></item>
///   <item><description><c>1</c> - <b>Enabled for VAP AU.</b></description></item>
///   <item><description><c>2</c> - <b>Enabled for VCORE AU.</b></description></item>
/// </list>
/// <para>
///   &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ParametersAccountUpdaterEnabled2>))]
public sealed record ParametersAccountUpdaterEnabled2 : OpenIntEnum<ParametersAccountUpdaterEnabled2>
{
    private ParametersAccountUpdaterEnabled2(long value) : base(value)
    {
    }

    public static readonly ParametersAccountUpdaterEnabled2 Value0 = new(0L);

    public static readonly ParametersAccountUpdaterEnabled2 Value1 = new(1L);

    public static readonly ParametersAccountUpdaterEnabled2 Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue0,
        Func<TResult> onValue1,
        Func<TResult> onValue2,
        Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value0 => onValue0(),
            _ when this == Value1 => onValue1(),
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue0, Action onValue1, Action onValue2, Action<long> otherwise)
    {
        if (this == Value0) onValue0();
        else if (this == Value1) onValue1();
        else if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
