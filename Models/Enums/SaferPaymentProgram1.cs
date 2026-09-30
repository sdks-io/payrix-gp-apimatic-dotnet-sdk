using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// This field contains the program type of the saferPayments.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>basic</c> - <b>Basic</b></description></item>
///   <item><description><c>managed</c> - <b>Managed</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SaferPaymentProgram1>))]
public sealed record SaferPaymentProgram1 : OpenStringEnum<SaferPaymentProgram1>
{
    private SaferPaymentProgram1(string value) : base(value)
    {
    }

    public static readonly SaferPaymentProgram1 Basic = new("basic");

    public static readonly SaferPaymentProgram1 Managed = new("managed");

    public TResult Match<TResult>(Func<TResult> onBasic, Func<TResult> onManaged, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Basic => onBasic(),
            _ when this == Managed => onManaged(),
            _ => otherwise(Value)
        };

    public void Match(Action onBasic, Action onManaged, Action<string> otherwise)
    {
        if (this == Basic) onBasic();
        else if (this == Managed) onManaged();
        else otherwise(Value);
    }
}
