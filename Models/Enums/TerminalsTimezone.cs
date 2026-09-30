using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TerminalsTimezone>))]
public sealed record TerminalsTimezone : OpenStringEnum<TerminalsTimezone>
{
    private TerminalsTimezone(string value) : base(value)
    {
    }

    public static readonly TerminalsTimezone Est = new("est");

    public static readonly TerminalsTimezone Cst = new("cst");

    public static readonly TerminalsTimezone Pst = new("pst");

    public static readonly TerminalsTimezone Mst = new("mst");

    public static readonly TerminalsTimezone Akst = new("akst");

    public static readonly TerminalsTimezone Hst = new("hst");

    public static readonly TerminalsTimezone Sst = new("sst");

    public static readonly TerminalsTimezone Chst = new("chst");

    public static readonly TerminalsTimezone Ast = new("ast");

    public static readonly TerminalsTimezone Pwt = new("pwt");

    public static readonly TerminalsTimezone Mht = new("mht");

    public static readonly TerminalsTimezone Chut = new("chut");

    public static readonly TerminalsTimezone Nst = new("nst");

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
