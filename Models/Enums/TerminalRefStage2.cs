using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An indicator showing what this terminalRef refers to, such as 'create', 'pid', 'tid', 'token', or 'ctid'.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>create</c>  -  <b>Terminal Creation</b></description></item>
///   <item><description><c>pid</c>  -  <b>Platform ID</b></description></item>
///   <item><description><c>tid</c>  -  <b>Terminal ID</b></description></item>
///   <item><description><c>token</c>  -  <b>Token ID</b></description></item>
///   <item><description><c>ctid</c>  -  <b>Custom Terminal ID</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TerminalRefStage2>))]
public sealed record TerminalRefStage2 : OpenStringEnum<TerminalRefStage2>
{
    private TerminalRefStage2(string value) : base(value)
    {
    }

    public static readonly TerminalRefStage2 Create = new("create");

    public static readonly TerminalRefStage2 Pid = new("pid");

    public static readonly TerminalRefStage2 Tid = new("tid");

    public static readonly TerminalRefStage2 Token = new("token");

    public static readonly TerminalRefStage2 Ctid = new("ctid");

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
