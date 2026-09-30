using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<NoteDocumentsDocumentType>))]
public sealed record NoteDocumentsDocumentType : OpenStringEnum<NoteDocumentsDocumentType>
{
    private NoteDocumentsDocumentType(string value) : base(value)
    {
    }

    public static readonly NoteDocumentsDocumentType General = new("general");

    public static readonly NoteDocumentsDocumentType PersonalId = new("personalId");

    public static readonly NoteDocumentsDocumentType CompanyId = new("companyId");

    public static readonly NoteDocumentsDocumentType VoidCheck = new("voidCheck");

    public static readonly NoteDocumentsDocumentType BankStatement = new("bankStatement");

    public static readonly NoteDocumentsDocumentType BankLetter = new("bankLetter");

    public static readonly NoteDocumentsDocumentType Contract = new("contract");

    public static readonly NoteDocumentsDocumentType TaxDocument = new("taxDocument");

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
