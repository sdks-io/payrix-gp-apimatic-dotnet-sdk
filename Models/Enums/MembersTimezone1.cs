using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The timezone for the address associated with the terminal's location.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>est</c> - <b>Eastern Standard Time</b></description></item>
///   <item><description><c>cst</c> - <b>Central Standard Time</b></description></item>
///   <item><description><c>pst</c> - <b>Pacific Standard Time</b></description></item>
///   <item><description><c>mst</c> - <b>Mountain Daylight Time</b></description></item>
///   <item><description><c>akst</c> - <b>Alaska Standard Time</b></description></item>
///   <item><description><c>hst</c> - <b>Hawaii Standard Time</b></description></item>
///   <item><description><c>sst</c> - <b>Samoa Standard Time</b></description></item>
///   <item><description><c>chst</c> - <b>Chamorro Standard Time</b></description></item>
///   <item><description><c>ast</c> - <b>Atlantic Standard Time</b></description></item>
///   <item><description><c>pwt</c> - <b>Palau Time</b></description></item>
///   <item><description><c>mht</c> - <b>Marshall Islands Time</b></description></item>
///   <item><description><c>chut</c> - <b>Chuuk Time</b></description></item>
///   <item><description><c>nst</c> - <b>Newfoundland Standard Time</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MembersTimezone1>))]
public sealed record MembersTimezone1 : OpenStringEnum<MembersTimezone1>
{
    private MembersTimezone1(string value) : base(value)
    {
    }

    public static readonly MembersTimezone1 Est = new("est");

    public static readonly MembersTimezone1 Cst = new("cst");

    public static readonly MembersTimezone1 Pst = new("pst");

    public static readonly MembersTimezone1 Mst = new("mst");

    public static readonly MembersTimezone1 Akst = new("akst");

    public static readonly MembersTimezone1 Hst = new("hst");

    public static readonly MembersTimezone1 Sst = new("sst");

    public static readonly MembersTimezone1 Chst = new("chst");

    public static readonly MembersTimezone1 Ast = new("ast");

    public static readonly MembersTimezone1 Pwt = new("pwt");

    public static readonly MembersTimezone1 Mht = new("mht");

    public static readonly MembersTimezone1 Chut = new("chut");

    public static readonly MembersTimezone1 Nst = new("nst");

    public TResult Match<TResult>(Func<TResult> onEst,
        Func<TResult> onCst,
        Func<TResult> onPst,
        Func<TResult> onMst,
        Func<TResult> onAkst,
        Func<TResult> onHst,
        Func<TResult> onSst,
        Func<TResult> onChst,
        Func<TResult> onAst,
        Func<TResult> onPwt,
        Func<TResult> onMht,
        Func<TResult> onChut,
        Func<TResult> onNst,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Est => onEst(),
            _ when this == Cst => onCst(),
            _ when this == Pst => onPst(),
            _ when this == Mst => onMst(),
            _ when this == Akst => onAkst(),
            _ when this == Hst => onHst(),
            _ when this == Sst => onSst(),
            _ when this == Chst => onChst(),
            _ when this == Ast => onAst(),
            _ when this == Pwt => onPwt(),
            _ when this == Mht => onMht(),
            _ when this == Chut => onChut(),
            _ when this == Nst => onNst(),
            _ => otherwise(Value)
        };

    public void Match(Action onEst,
        Action onCst,
        Action onPst,
        Action onMst,
        Action onAkst,
        Action onHst,
        Action onSst,
        Action onChst,
        Action onAst,
        Action onPwt,
        Action onMht,
        Action onChut,
        Action onNst,
        Action<string> otherwise)
    {
        if (this == Est) onEst();
        else if (this == Cst) onCst();
        else if (this == Pst) onPst();
        else if (this == Mst) onMst();
        else if (this == Akst) onAkst();
        else if (this == Hst) onHst();
        else if (this == Sst) onSst();
        else if (this == Chst) onChst();
        else if (this == Ast) onAst();
        else if (this == Pwt) onPwt();
        else if (this == Mht) onMht();
        else if (this == Chut) onChut();
        else if (this == Nst) onNst();
        else otherwise(Value);
    }
}
