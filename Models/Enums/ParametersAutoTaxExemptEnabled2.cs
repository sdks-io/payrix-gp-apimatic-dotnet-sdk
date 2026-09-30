using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Whether to assume a transaction is tax-exempt if no tax is set for Level II processing. The default setting is <c>0</c>.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Disabled</b></description></item>
///   <item><description><c>1</c> - <b>Enabled</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ParametersAutoTaxExemptEnabled2>))]
public sealed record ParametersAutoTaxExemptEnabled2 : OpenIntEnum<ParametersAutoTaxExemptEnabled2>
{
    private ParametersAutoTaxExemptEnabled2(long value) : base(value)
    {
    }

    public static readonly ParametersAutoTaxExemptEnabled2 Value0 = new(0L);

    public static readonly ParametersAutoTaxExemptEnabled2 Value1 = new(1L);

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
