using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentsDocumentSource>))]
public sealed record ChargebackDocumentsDocumentSource : OpenStringEnum<ChargebackDocumentsDocumentSource>
{
    private ChargebackDocumentsDocumentSource(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentsDocumentSource Merchant = new("merchant");

    public static readonly ChargebackDocumentsDocumentSource Issuer = new("issuer");

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
