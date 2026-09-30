using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Indicates if the TIN being used is an EIN, SSN, or other/unknown number.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>ssn</c> - <b>Social Security Number.</b></description></item>
///   <item><description><c>tin</c> - <b>Employer Identification Number.</b></description></item>
///   <item><description><c>other</c> - <b>Other/Unknown TIN.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntitiesEinType1>))]
public sealed record EntitiesEinType1 : OpenStringEnum<EntitiesEinType1>
{
    private EntitiesEinType1(string value) : base(value)
    {
    }

    public static readonly EntitiesEinType1 Ssn = new("ssn");

    public static readonly EntitiesEinType1 Tin = new("tin");

    public static readonly EntitiesEinType1 Other = new("other");

    public TResult Match<TResult>(Func<TResult> onSsn,
        Func<TResult> onTin,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ssn => onSsn(),
            _ when this == Tin => onTin(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onSsn, Action onTin, Action onOther, Action<string> otherwise)
    {
        if (this == Ssn) onSsn();
        else if (this == Tin) onTin();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
