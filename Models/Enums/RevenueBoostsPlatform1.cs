using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The platform used to process this transaction.
/// Valid Values : - <c>VCORE</c> - <b>VCORE</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RevenueBoostsPlatform1>))]
public sealed record RevenueBoostsPlatform1 : OpenStringEnum<RevenueBoostsPlatform1>
{
    private RevenueBoostsPlatform1(string value) : base(value)
    {
    }

    public static readonly RevenueBoostsPlatform1 Vcore = new("VCORE");

    public TResult Match<TResult>(Func<TResult> onVcore, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vcore => onVcore(),
            _ => otherwise(Value)
        };

    public void Match(Action onVcore, Action<string> otherwise)
    {
        if (this == Vcore) onVcore();
        else otherwise(Value);
    }
}
