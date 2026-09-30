using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// 'A controlling authority', or 'Control Prong'. Includes, but is not limited to:
/// <list type="bullet">
///   <item><description>Chief Executive Officer,</description></item>
///   <item><description>Chief Financial Officer,</description></item>
///   <item><description>Chief Operating Officer,</description></item>
///   <item><description>Managing Member,</description></item>
///   <item><description>General Partner,</description></item>
///   <item><description>President,</description></item>
///   <item><description>Vice Presidents, or</description></item>
///   <item><description>An individual with significant legal authority to enter the Legal Entity into a commercial relationship.</description></item>
/// </list>
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>No significant responsibility.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>1</c> - <b>Significant reponsibility.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MembersSignificantResponsibility1>))]
public sealed record MembersSignificantResponsibility1 : OpenIntEnum<MembersSignificantResponsibility1>
{
    private MembersSignificantResponsibility1(long value) : base(value)
    {
    }

    public static readonly MembersSignificantResponsibility1 Value0 = new(0L);

    public static readonly MembersSignificantResponsibility1 Value1 = new(1L);

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
