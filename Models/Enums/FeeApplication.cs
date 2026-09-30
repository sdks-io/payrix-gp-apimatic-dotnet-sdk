using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FeeApplication>))]
public sealed record FeeApplication : OpenStringEnum<FeeApplication>
{
    private FeeApplication(string value) : base(value)
    {
    }

    public static readonly FeeApplication Both = new("both");

    public static readonly FeeApplication Fee = new("fee");

    public static readonly FeeApplication Collection = new("collection");

    public TResult Match<TResult>(Func<TResult> onBoth,
        Func<TResult> onFee,
        Func<TResult> onCollection,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Both => onBoth(),
            _ when this == Fee => onFee(),
            _ when this == Collection => onCollection(),
            _ => otherwise(Value)
        };

    public void Match(Action onBoth, Action onFee, Action onCollection, Action<string> otherwise)
    {
        if (this == Both) onBoth();
        else if (this == Fee) onFee();
        else if (this == Collection) onCollection();
        else otherwise(Value);
    }
}
