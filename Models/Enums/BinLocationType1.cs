using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of location of this banking institution. Used in <c>bankAccount</c> type bins.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>branch</c> - <b>Branch location.</b></description></item>
///   <item><description><c>main</c> - <b>Main headquarters.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BinLocationType1>))]
public sealed record BinLocationType1 : OpenStringEnum<BinLocationType1>
{
    private BinLocationType1(string value) : base(value)
    {
    }

    public static readonly BinLocationType1 Branch = new("branch");

    public static readonly BinLocationType1 Main = new("main");

    public TResult Match<TResult>(Func<TResult> onBranch, Func<TResult> onMain, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Branch => onBranch(),
            _ when this == Main => onMain(),
            _ => otherwise(Value)
        };

    public void Match(Action onBranch, Action onMain, Action<string> otherwise)
    {
        if (this == Branch) onBranch();
        else if (this == Main) onMain();
        else otherwise(Value);
    }
}
