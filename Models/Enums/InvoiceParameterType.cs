using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<InvoiceParameterType>))]
public sealed record InvoiceParameterType : OpenStringEnum<InvoiceParameterType>
{
    private InvoiceParameterType(string value) : base(value)
    {
    }

    public static readonly InvoiceParameterType Apikey = new("apikey");

    public static readonly InvoiceParameterType FromEmail = new("fromEmail");

    public static readonly InvoiceParameterType ReplyToEmail = new("replyToEmail");

    public static readonly InvoiceParameterType Dba = new("dba");

    public static readonly InvoiceParameterType Address1 = new("address1");

    public static readonly InvoiceParameterType Address2 = new("address2");

    public static readonly InvoiceParameterType City = new("city");

    public static readonly InvoiceParameterType State = new("state");

    public static readonly InvoiceParameterType Zip = new("zip");

    public static readonly InvoiceParameterType Country = new("country");

    public static readonly InvoiceParameterType Phone = new("phone");

    public static readonly InvoiceParameterType Website = new("website");

    public static readonly InvoiceParameterType ReceiptTitle = new("receiptTitle");

    public static readonly InvoiceParameterType ReceiptMessage = new("receiptMessage");

    public static readonly InvoiceParameterType BillingRequired = new("billingRequired");

    public static readonly InvoiceParameterType ShippingRequired = new("shippingRequired");

    public static readonly InvoiceParameterType ECheckAuthorization = new("eCheckAuthorization");

    public TResult Match<TResult>(Func<TResult> onApikey,
        Func<TResult> onFromEmail,
        Func<TResult> onReplyToEmail,
        Func<TResult> onDba,
        Func<TResult> onAddress1,
        Func<TResult> onAddress2,
        Func<TResult> onCity,
        Func<TResult> onState,
        Func<TResult> onZip,
        Func<TResult> onCountry,
        Func<TResult> onPhone,
        Func<TResult> onWebsite,
        Func<TResult> onReceiptTitle,
        Func<TResult> onReceiptMessage,
        Func<TResult> onBillingRequired,
        Func<TResult> onShippingRequired,
        Func<TResult> onECheckAuthorization,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Apikey => onApikey(),
            _ when this == FromEmail => onFromEmail(),
            _ when this == ReplyToEmail => onReplyToEmail(),
            _ when this == Dba => onDba(),
            _ when this == Address1 => onAddress1(),
            _ when this == Address2 => onAddress2(),
            _ when this == City => onCity(),
            _ when this == State => onState(),
            _ when this == Zip => onZip(),
            _ when this == Country => onCountry(),
            _ when this == Phone => onPhone(),
            _ when this == Website => onWebsite(),
            _ when this == ReceiptTitle => onReceiptTitle(),
            _ when this == ReceiptMessage => onReceiptMessage(),
            _ when this == BillingRequired => onBillingRequired(),
            _ when this == ShippingRequired => onShippingRequired(),
            _ when this == ECheckAuthorization => onECheckAuthorization(),
            _ => otherwise(Value)
        };

    public void Match(Action onApikey,
        Action onFromEmail,
        Action onReplyToEmail,
        Action onDba,
        Action onAddress1,
        Action onAddress2,
        Action onCity,
        Action onState,
        Action onZip,
        Action onCountry,
        Action onPhone,
        Action onWebsite,
        Action onReceiptTitle,
        Action onReceiptMessage,
        Action onBillingRequired,
        Action onShippingRequired,
        Action onECheckAuthorization,
        Action<string> otherwise)
    {
        if (this == Apikey) onApikey();
        else if (this == FromEmail) onFromEmail();
        else if (this == ReplyToEmail) onReplyToEmail();
        else if (this == Dba) onDba();
        else if (this == Address1) onAddress1();
        else if (this == Address2) onAddress2();
        else if (this == City) onCity();
        else if (this == State) onState();
        else if (this == Zip) onZip();
        else if (this == Country) onCountry();
        else if (this == Phone) onPhone();
        else if (this == Website) onWebsite();
        else if (this == ReceiptTitle) onReceiptTitle();
        else if (this == ReceiptMessage) onReceiptMessage();
        else if (this == BillingRequired) onBillingRequired();
        else if (this == ShippingRequired) onShippingRequired();
        else if (this == ECheckAuthorization) onECheckAuthorization();
        else otherwise(Value);
    }
}
