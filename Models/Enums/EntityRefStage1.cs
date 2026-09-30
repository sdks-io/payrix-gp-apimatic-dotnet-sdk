using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// An indicator showing what this terminalRef refers to.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>amexCharge</c> - <b>Amex Charge.</b></description></item>
///   <item><description><c>batch</c> - <b>Batch.</b></description></item>
///   <item><description><c>batchSuffix</c> - <b>Batch Suffix.</b></description></item>
///   <item><description><c>boarding</c> - <b>Boarding.</b></description></item>
///   <item><description><c>chain</c> - <b>The store chain ID for this Merchant.</b></description></item>
///   <item><description><c>chargeback</c> - <b>Chargeback.</b></description></item>
///   <item><description><c>companyDebit</c> - <b>Company Debit.</b></description></item>
///   <item><description><c>companyCredit</c> - <b>Company Credit.</b></description></item>
///   <item><description><c>create</c> - <b>Terminal Creation.</b></description></item>
///   <item><description><c>disbursement</c> - <b>Disbursement.</b></description></item>
///   <item><description><c>entity</c> - <b>The Entity ID.</b></description></item>
///   <item><description><c>batchFile</c> - <b>Batch File.</b></description></item>
///   <item><description><c>payoutFile</c> - <b>Payout File.</b></description></item>
///   <item><description><c>frontend</c> - <b>Frontend.</b></description></item>
///   <item><description><c>funding</c> - <b>The Payout funding ID for this Merchant.</b></description></item>
///   <item><description><c>member</c> - <b>The member ID for this Member.</b></description></item>
///   <item><description><c>merchant</c> - <b>The Merchant ID.</b></description></item>
///   <item><description><c>mid</c> - <b>The transaction Merchant ID (MID).</b></description></item>
///   <item><description><c>origId</c> - <b>Original ID.</b></description></item>
///   <item><description><c>store</c> - <b>The store ID for this Merchant.</b></description></item>
///   <item><description><c>software</c> - <b>Software.</b></description></item>
///   <item><description><c>terminal</c> - <b>Terminal.</b></description></item>
///   <item><description><c>displayName</c> - <b>Display Name.</b></description></item>
///   <item><description><c>domain</c> - <b>Domain.</b></description></item>
///   <item><description><c>expressCreds</c> - <b>Express Credentials.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityRefStage1>))]
public sealed record EntityRefStage1 : OpenStringEnum<EntityRefStage1>
{
    private EntityRefStage1(string value) : base(value)
    {
    }

    public static readonly EntityRefStage1 AmexCharge = new("amexCharge");

    public static readonly EntityRefStage1 Batch = new("batch");

    public static readonly EntityRefStage1 BatchSuffix = new("batchSuffix");

    public static readonly EntityRefStage1 Boarding = new("boarding");

    public static readonly EntityRefStage1 Chain = new("chain");

    public static readonly EntityRefStage1 Chargeback = new("chargeback");

    public static readonly EntityRefStage1 CompanyDebit = new("companyDebit");

    public static readonly EntityRefStage1 CompanyCredit = new("companyCredit");

    public static readonly EntityRefStage1 Create = new("create");

    public static readonly EntityRefStage1 Disbursement = new("disbursement");

    public static readonly EntityRefStage1 Entity = new("entity");

    public static readonly EntityRefStage1 BatchFile = new("batchFile");

    public static readonly EntityRefStage1 PayoutFile = new("payoutFile");

    public static readonly EntityRefStage1 Frontend = new("frontend");

    public static readonly EntityRefStage1 Funding = new("funding");

    public static readonly EntityRefStage1 Member = new("member");

    public static readonly EntityRefStage1 Merchant = new("merchant");

    public static readonly EntityRefStage1 Mid = new("mid");

    public static readonly EntityRefStage1 OrigId = new("origId");

    public static readonly EntityRefStage1 Store = new("store");

    public static readonly EntityRefStage1 Software = new("software");

    public static readonly EntityRefStage1 Terminal = new("terminal");

    public static readonly EntityRefStage1 DisplayName = new("displayName");

    public static readonly EntityRefStage1 Domain = new("domain");

    public static readonly EntityRefStage1 ExpressCreds = new("expressCreds");

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
