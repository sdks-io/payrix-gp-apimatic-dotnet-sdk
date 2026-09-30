using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// This field indicates the entity's current PCI compliance status for the service.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>compliance</c> - <b>Compliance</b></description></item>
///   <item><description><c>non-compliance</c> - <b>Non-Compliance</b></description></item>
///   <item><description><c>pending</c> - <b>Pending</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SaferPaymentStatus1>))]
public sealed record SaferPaymentStatus1 : OpenStringEnum<SaferPaymentStatus1>
{
    private SaferPaymentStatus1(string value) : base(value)
    {
    }

    public static readonly SaferPaymentStatus1 Compliance = new("compliance");

    public static readonly SaferPaymentStatus1 NonCompliance = new("non-compliance");

    public static readonly SaferPaymentStatus1 Pending = new("pending");

    public TResult Match<TResult>(Func<TResult> onCompliance,
        Func<TResult> onNonCompliance,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Compliance => onCompliance(),
            _ when this == NonCompliance => onNonCompliance(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompliance, Action onNonCompliance, Action onPending, Action<string> otherwise)
    {
        if (this == Compliance) onCompliance();
        else if (this == NonCompliance) onNonCompliance();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
