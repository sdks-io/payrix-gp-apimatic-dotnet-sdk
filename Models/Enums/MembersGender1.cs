using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The gender of this Member.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>male</c> - <b>Male</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>female</c> - <b>Female</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MembersGender1>))]
public sealed record MembersGender1 : OpenStringEnum<MembersGender1>
{
    private MembersGender1(string value) : base(value)
    {
    }

    public static readonly MembersGender1 Male = new("male");

    public static readonly MembersGender1 Female = new("female");

    public TResult Match<TResult>(Func<TResult> onMale, Func<TResult> onFemale, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Male => onMale(),
            _ when this == Female => onFemale(),
            _ => otherwise(Value)
        };

    public void Match(Action onMale, Action onFemale, Action<string> otherwise)
    {
        if (this == Male) onMale();
        else if (this == Female) onFemale();
        else otherwise(Value);
    }
}
