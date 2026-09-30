using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of the CVV on the card.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>notPresent</c> - <b>CVV is not present.</b></description></item>
///   <item><description><c>illegible</c> - <b>CVV is illegible.</b></description></item>
///   <item><description><c>notProvided</c> - <b>CVV was not provided.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalTxnsCvvStatus1>))]
public sealed record TerminalTxnsCvvStatus1 : OpenStringEnum<TerminalTxnsCvvStatus1>
{
    private TerminalTxnsCvvStatus1(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsCvvStatus1 NotPresent = new("notPresent");

    public static readonly TerminalTxnsCvvStatus1 Illegible = new("illegible");

    public static readonly TerminalTxnsCvvStatus1 NotProvided = new("notProvided");

    public TResult Match<TResult>(Func<TResult> onNotPresent,
        Func<TResult> onIllegible,
        Func<TResult> onNotProvided,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotPresent => onNotPresent(),
            _ when this == Illegible => onIllegible(),
            _ when this == NotProvided => onNotProvided(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotPresent, Action onIllegible, Action onNotProvided, Action<string> otherwise)
    {
        if (this == NotPresent) onNotPresent();
        else if (this == Illegible) onIllegible();
        else if (this == NotProvided) onNotProvided();
        else otherwise(Value);
    }
}
