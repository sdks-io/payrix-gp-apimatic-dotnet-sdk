using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityRefStage>))]
public sealed record EntityRefStage : OpenStringEnum<EntityRefStage>
{
    private EntityRefStage(string value) : base(value)
    {
    }

    public static readonly EntityRefStage AmexCharge = new("amexCharge");

    public static readonly EntityRefStage Batch = new("batch");

    public static readonly EntityRefStage BatchSuffix = new("batchSuffix");

    public static readonly EntityRefStage Boarding = new("boarding");

    public static readonly EntityRefStage Chain = new("chain");

    public static readonly EntityRefStage Chargeback = new("chargeback");

    public static readonly EntityRefStage CompanyDebit = new("companyDebit");

    public static readonly EntityRefStage CompanyCredit = new("companyCredit");

    public static readonly EntityRefStage Create = new("create");

    public static readonly EntityRefStage Disbursement = new("disbursement");

    public static readonly EntityRefStage Entity = new("entity");

    public static readonly EntityRefStage BatchFile = new("batchFile");

    public static readonly EntityRefStage PayoutFile = new("payoutFile");

    public static readonly EntityRefStage Frontend = new("frontend");

    public static readonly EntityRefStage Funding = new("funding");

    public static readonly EntityRefStage Member = new("member");

    public static readonly EntityRefStage Merchant = new("merchant");

    public static readonly EntityRefStage Mid = new("mid");

    public static readonly EntityRefStage OrigId = new("origId");

    public static readonly EntityRefStage Store = new("store");

    public static readonly EntityRefStage Software = new("software");

    public static readonly EntityRefStage Terminal = new("terminal");

    public static readonly EntityRefStage DisplayName = new("displayName");

    public static readonly EntityRefStage Domain = new("domain");

    public static readonly EntityRefStage ExpressCreds = new("expressCreds");

    public TResult Match<TResult>(Func<TResult> onAmexCharge,
        Func<TResult> onBatch,
        Func<TResult> onBatchSuffix,
        Func<TResult> onBoarding,
        Func<TResult> onChain,
        Func<TResult> onChargeback,
        Func<TResult> onCompanyDebit,
        Func<TResult> onCompanyCredit,
        Func<TResult> onCreate,
        Func<TResult> onDisbursement,
        Func<TResult> onEntity,
        Func<TResult> onBatchFile,
        Func<TResult> onPayoutFile,
        Func<TResult> onFrontend,
        Func<TResult> onFunding,
        Func<TResult> onMember,
        Func<TResult> onMerchant,
        Func<TResult> onMid,
        Func<TResult> onOrigId,
        Func<TResult> onStore,
        Func<TResult> onSoftware,
        Func<TResult> onTerminal,
        Func<TResult> onDisplayName,
        Func<TResult> onDomain,
        Func<TResult> onExpressCreds,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AmexCharge => onAmexCharge(),
            _ when this == Batch => onBatch(),
            _ when this == BatchSuffix => onBatchSuffix(),
            _ when this == Boarding => onBoarding(),
            _ when this == Chain => onChain(),
            _ when this == Chargeback => onChargeback(),
            _ when this == CompanyDebit => onCompanyDebit(),
            _ when this == CompanyCredit => onCompanyCredit(),
            _ when this == Create => onCreate(),
            _ when this == Disbursement => onDisbursement(),
            _ when this == Entity => onEntity(),
            _ when this == BatchFile => onBatchFile(),
            _ when this == PayoutFile => onPayoutFile(),
            _ when this == Frontend => onFrontend(),
            _ when this == Funding => onFunding(),
            _ when this == Member => onMember(),
            _ when this == Merchant => onMerchant(),
            _ when this == Mid => onMid(),
            _ when this == OrigId => onOrigId(),
            _ when this == Store => onStore(),
            _ when this == Software => onSoftware(),
            _ when this == Terminal => onTerminal(),
            _ when this == DisplayName => onDisplayName(),
            _ when this == Domain => onDomain(),
            _ when this == ExpressCreds => onExpressCreds(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmexCharge,
        Action onBatch,
        Action onBatchSuffix,
        Action onBoarding,
        Action onChain,
        Action onChargeback,
        Action onCompanyDebit,
        Action onCompanyCredit,
        Action onCreate,
        Action onDisbursement,
        Action onEntity,
        Action onBatchFile,
        Action onPayoutFile,
        Action onFrontend,
        Action onFunding,
        Action onMember,
        Action onMerchant,
        Action onMid,
        Action onOrigId,
        Action onStore,
        Action onSoftware,
        Action onTerminal,
        Action onDisplayName,
        Action onDomain,
        Action onExpressCreds,
        Action<string> otherwise)
    {
        if (this == AmexCharge) onAmexCharge();
        else if (this == Batch) onBatch();
        else if (this == BatchSuffix) onBatchSuffix();
        else if (this == Boarding) onBoarding();
        else if (this == Chain) onChain();
        else if (this == Chargeback) onChargeback();
        else if (this == CompanyDebit) onCompanyDebit();
        else if (this == CompanyCredit) onCompanyCredit();
        else if (this == Create) onCreate();
        else if (this == Disbursement) onDisbursement();
        else if (this == Entity) onEntity();
        else if (this == BatchFile) onBatchFile();
        else if (this == PayoutFile) onPayoutFile();
        else if (this == Frontend) onFrontend();
        else if (this == Funding) onFunding();
        else if (this == Member) onMember();
        else if (this == Merchant) onMerchant();
        else if (this == Mid) onMid();
        else if (this == OrigId) onOrigId();
        else if (this == Store) onStore();
        else if (this == Software) onSoftware();
        else if (this == Terminal) onTerminal();
        else if (this == DisplayName) onDisplayName();
        else if (this == Domain) onDomain();
        else if (this == ExpressCreds) onExpressCreds();
        else otherwise(Value);
    }
}
