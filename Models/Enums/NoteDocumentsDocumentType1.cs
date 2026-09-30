using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The purpose of the document upload.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>general</c> - <b>General use for unspecified type.</b></description></item>
///   <item><description><c>personalId</c> - <b>An identification document for a person.</b></description></item>
///   <item><description><c>companyId</c> - <b>An identification document for a company.</b></description></item>
///   <item><description><c>voidCheck</c> - <b>A voided check for bank account verification.</b></description></item>
///   <item><description><c>bankStatement</c> - <b>A bank statement.</b></description></item>
///   <item><description><c>bankLetter</c> - <b>A bank letter for verification.</b></description></item>
///   <item><description><c>contract</c> - <b>A contract for goods or services.</b></description></item>
///   <item><description><c>taxDocument</c> - <b>A tax document for verification.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NoteDocumentsDocumentType1>))]
public sealed record NoteDocumentsDocumentType1 : OpenStringEnum<NoteDocumentsDocumentType1>
{
    private NoteDocumentsDocumentType1(string value) : base(value)
    {
    }

    public static readonly NoteDocumentsDocumentType1 General = new("general");

    public static readonly NoteDocumentsDocumentType1 PersonalId = new("personalId");

    public static readonly NoteDocumentsDocumentType1 CompanyId = new("companyId");

    public static readonly NoteDocumentsDocumentType1 VoidCheck = new("voidCheck");

    public static readonly NoteDocumentsDocumentType1 BankStatement = new("bankStatement");

    public static readonly NoteDocumentsDocumentType1 BankLetter = new("bankLetter");

    public static readonly NoteDocumentsDocumentType1 Contract = new("contract");

    public static readonly NoteDocumentsDocumentType1 TaxDocument = new("taxDocument");

    public TResult Match<TResult>(Func<TResult> onGeneral,
        Func<TResult> onPersonalId,
        Func<TResult> onCompanyId,
        Func<TResult> onVoidCheck,
        Func<TResult> onBankStatement,
        Func<TResult> onBankLetter,
        Func<TResult> onContract,
        Func<TResult> onTaxDocument,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == General => onGeneral(),
            _ when this == PersonalId => onPersonalId(),
            _ when this == CompanyId => onCompanyId(),
            _ when this == VoidCheck => onVoidCheck(),
            _ when this == BankStatement => onBankStatement(),
            _ when this == BankLetter => onBankLetter(),
            _ when this == Contract => onContract(),
            _ when this == TaxDocument => onTaxDocument(),
            _ => otherwise(Value)
        };

    public void Match(Action onGeneral,
        Action onPersonalId,
        Action onCompanyId,
        Action onVoidCheck,
        Action onBankStatement,
        Action onBankLetter,
        Action onContract,
        Action onTaxDocument,
        Action<string> otherwise)
    {
        if (this == General) onGeneral();
        else if (this == PersonalId) onPersonalId();
        else if (this == CompanyId) onCompanyId();
        else if (this == VoidCheck) onVoidCheck();
        else if (this == BankStatement) onBankStatement();
        else if (this == BankLetter) onBankLetter();
        else if (this == Contract) onContract();
        else if (this == TaxDocument) onTaxDocument();
        else otherwise(Value);
    }
}
