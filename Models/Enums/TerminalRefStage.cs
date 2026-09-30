using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalRefStage>))]
public sealed record TerminalRefStage : OpenStringEnum<TerminalRefStage>
{
    private TerminalRefStage(string value) : base(value)
    {
    }

    public static readonly TerminalRefStage Create = new("create");

    public static readonly TerminalRefStage Pid = new("pid");

    public static readonly TerminalRefStage Tid = new("tid");

    public static readonly TerminalRefStage Token = new("token");

    public static readonly TerminalRefStage Ctid = new("ctid");

    public TResult Match<TResult>(Func<TResult> onCreate,
        Func<TResult> onPid,
        Func<TResult> onTid,
        Func<TResult> onToken,
        Func<TResult> onCtid,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Create => onCreate(),
            _ when this == Pid => onPid(),
            _ when this == Tid => onTid(),
            _ when this == Token => onToken(),
            _ when this == Ctid => onCtid(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreate,
        Action onPid,
        Action onTid,
        Action onToken,
        Action onCtid,
        Action<string> otherwise)
    {
        if (this == Create) onCreate();
        else if (this == Pid) onPid();
        else if (this == Tid) onTid();
        else if (this == Token) onToken();
        else if (this == Ctid) onCtid();
        else otherwise(Value);
    }
}
