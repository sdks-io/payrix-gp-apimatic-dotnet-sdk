using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The status of this invoiceResult
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>success</c> - <b>Successfuly processed.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>failure</c> - <b>Failed to process.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InvoiceResultStatus1>))]
public sealed record InvoiceResultStatus1 : OpenStringEnum<InvoiceResultStatus1>
{
    private InvoiceResultStatus1(string value) : base(value)
    {
    }

    public static readonly InvoiceResultStatus1 Success = new("success");

    public static readonly InvoiceResultStatus1 Failure = new("failure");

    public TResult Match<TResult>(Func<TResult> onSuccess, Func<TResult> onFailure, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
