using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The source of the document.
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// - <c>merchant</c> - <b>Merchant.</b>
/// - <c>issuer</c> - <b>Issuer.</b>
/// &lt;/details&gt;
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentsDocumentSource1>))]
public sealed record ChargebackDocumentsDocumentSource1 : OpenStringEnum<ChargebackDocumentsDocumentSource1>
{
    private ChargebackDocumentsDocumentSource1(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentsDocumentSource1 Merchant = new("merchant");

    public static readonly ChargebackDocumentsDocumentSource1 Issuer = new("issuer");

    public TResult Match<TResult>(Func<TResult> onMerchant, Func<TResult> onIssuer, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Merchant => onMerchant(),
            _ when this == Issuer => onIssuer(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchant, Action onIssuer, Action<string> otherwise)
    {
        if (this == Merchant) onMerchant();
        else if (this == Issuer) onIssuer();
        else otherwise(Value);
    }
}
