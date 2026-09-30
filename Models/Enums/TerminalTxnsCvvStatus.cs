using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalTxnsCvvStatus>))]
public sealed record TerminalTxnsCvvStatus : OpenStringEnum<TerminalTxnsCvvStatus>
{
    private TerminalTxnsCvvStatus(string value) : base(value)
    {
    }

    public static readonly TerminalTxnsCvvStatus NotPresent = new("notPresent");

    public static readonly TerminalTxnsCvvStatus Illegible = new("illegible");

    public static readonly TerminalTxnsCvvStatus NotProvided = new("notProvided");

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
