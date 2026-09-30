using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountsUpdateMethod>))]
public sealed record AccountsUpdateMethod : OpenStringEnum<AccountsUpdateMethod>
{
    private AccountsUpdateMethod(string value) : base(value)
    {
    }

    public static readonly AccountsUpdateMethod Noc = new("NOC");

    public static readonly AccountsUpdateMethod Plaid = new("PLAID");

    public static readonly AccountsUpdateMethod Manual = new("MANUAL");

    public TResult Match<TResult>(Func<TResult> onNoc,
        Func<TResult> onPlaid,
        Func<TResult> onManual,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Noc => onNoc(),
            _ when this == Plaid => onPlaid(),
            _ when this == Manual => onManual(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoc, Action onPlaid, Action onManual, Action<string> otherwise)
    {
        if (this == Noc) onNoc();
        else if (this == Plaid) onPlaid();
        else if (this == Manual) onManual();
        else otherwise(Value);
    }
}
