using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The method used to update the account.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>NOC</c> - <b>Notification of change</b></description></item>
///   <item><description><c>PLAID</c> - <b>Plaid.</b></description></item>
///   <item><description><c>MANUAL</c> - <b>Manual</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountsUpdateMethod1>))]
public sealed record AccountsUpdateMethod1 : OpenStringEnum<AccountsUpdateMethod1>
{
    private AccountsUpdateMethod1(string value) : base(value)
    {
    }

    public static readonly AccountsUpdateMethod1 Noc = new("NOC");

    public static readonly AccountsUpdateMethod1 Plaid = new("PLAID");

    public static readonly AccountsUpdateMethod1 Manual = new("MANUAL");

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
