using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of this merchant platform.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>0</c> - <b>Pending.</b></description></item>
///   <item><description><c>1</c> - <b>Approved.</b></description></item>
///   <item><description><c>2</c> - <b>Failed.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : OpenStringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 _0 = new("0");

    public static readonly Status2 _1 = new("1");

    public static readonly Status2 _2 = new("2");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action on_2, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else otherwise(Value);
    }
}
