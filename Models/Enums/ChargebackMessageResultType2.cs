using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of this chargebackMessageResult.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>general</c> - <b>A general type of result.</b></description></item>
///   <item><description><c>platform</c> - <b>Platform message.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackMessageResultType2>))]
public sealed record ChargebackMessageResultType2 : OpenStringEnum<ChargebackMessageResultType2>
{
    private ChargebackMessageResultType2(string value) : base(value)
    {
    }

    public static readonly ChargebackMessageResultType2 General = new("general");

    public static readonly ChargebackMessageResultType2 Platform = new("platform");

    public TResult Match<TResult>(Func<TResult> onGeneral, Func<TResult> onPlatform, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == General => onGeneral(),
            _ when this == Platform => onPlatform(),
            _ => otherwise(Value)
        };

    public void Match(Action onGeneral, Action onPlatform, Action<string> otherwise)
    {
        if (this == General) onGeneral();
        else if (this == Platform) onPlatform();
        else otherwise(Value);
    }
}
