using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DecisionRuleType>))]
public sealed record DecisionRuleType : OpenStringEnum<DecisionRuleType>
{
    private DecisionRuleType(string value) : base(value)
    {
    }

    public static readonly DecisionRuleType Less = new("less");

    public static readonly DecisionRuleType Equal = new("equal");

    public static readonly DecisionRuleType NotEqual = new("notEqual");

    public static readonly DecisionRuleType Greater = new("greater");

    public static readonly DecisionRuleType Swiped = new("swiped");

    public static readonly DecisionRuleType Signed = new("signed");

    public static readonly DecisionRuleType Type = new("type");

    public static readonly DecisionRuleType Origin = new("origin");

    public static readonly DecisionRuleType Method = new("method");

    public static readonly DecisionRuleType CvvResult = new("cvvResult");

    public static readonly DecisionRuleType AvsResult = new("avsResult");

    public static readonly DecisionRuleType _3DsResult = new("3dsResult");

    public static readonly DecisionRuleType Related = new("related");

    public static readonly DecisionRuleType RelatedDelay = new("relatedDelay");

    public static readonly DecisionRuleType RelatedFloor = new("relatedFloor");

    public static readonly DecisionRuleType RelatedCeil = new("relatedCeil");

    public static readonly DecisionRuleType Mcc = new("mcc");

    public static readonly DecisionRuleType MerchantCountry = new("merchantCountry");

    public static readonly DecisionRuleType IssuerCountry = new("issuerCountry");

    public static readonly DecisionRuleType International = new("international");

    public static readonly DecisionRuleType Platform = new("platform");

    public static readonly DecisionRuleType MethodType = new("methodType");

    public static readonly DecisionRuleType Emv = new("emv");

    public static readonly DecisionRuleType Misuse = new("misuse");

    public static readonly DecisionRuleType Bin = new("bin");

    public static readonly DecisionRuleType Primary = new("primary");

    public static readonly DecisionRuleType FundingCurrencyEqual = new("fundingCurrencyEqual");

    public static readonly DecisionRuleType FundingCurrencyNotEqual = new("fundingCurrencyNotEqual");

    public static readonly DecisionRuleType FundingCurrencyMismatch = new("fundingCurrencyMismatch");

    public static readonly DecisionRuleType SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly DecisionRuleType Imported = new("imported");

    public static readonly DecisionRuleType Subscription = new("subscription");

    public static readonly DecisionRuleType PublicAuth = new("publicAuth");

    public static readonly DecisionRuleType ClientIp = new("clientIp");

    public static readonly DecisionRuleType DebtRepayment = new("debtRepayment");

    public static readonly DecisionRuleType CofType = new("cofType");

    public static readonly DecisionRuleType EntryMode = new("entryMode");

    public TResult Match<TResult>(Func<TResult> onLess,
        Func<TResult> onEqual,
        Func<TResult> onNotEqual,
        Func<TResult> onGreater,
        Func<TResult> onSwiped,
        Func<TResult> onSigned,
        Func<TResult> onType,
        Func<TResult> onOrigin,
        Func<TResult> onMethod,
        Func<TResult> onCvvResult,
        Func<TResult> onAvsResult,
        Func<TResult> on_3DsResult,
        Func<TResult> onRelated,
        Func<TResult> onRelatedDelay,
        Func<TResult> onRelatedFloor,
        Func<TResult> onRelatedCeil,
        Func<TResult> onMcc,
        Func<TResult> onMerchantCountry,
        Func<TResult> onIssuerCountry,
        Func<TResult> onInternational,
        Func<TResult> onPlatform,
        Func<TResult> onMethodType,
        Func<TResult> onEmv,
        Func<TResult> onMisuse,
        Func<TResult> onBin,
        Func<TResult> onPrimary,
        Func<TResult> onFundingCurrencyEqual,
        Func<TResult> onFundingCurrencyNotEqual,
        Func<TResult> onFundingCurrencyMismatch,
        Func<TResult> onSettledCurrencyMismatch,
        Func<TResult> onImported,
        Func<TResult> onSubscription,
        Func<TResult> onPublicAuth,
        Func<TResult> onClientIp,
        Func<TResult> onDebtRepayment,
        Func<TResult> onCofType,
        Func<TResult> onEntryMode,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Less => onLess(),
            _ when this == Equal => onEqual(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == Greater => onGreater(),
            _ when this == Swiped => onSwiped(),
            _ when this == Signed => onSigned(),
            _ when this == Type => onType(),
            _ when this == Origin => onOrigin(),
            _ when this == Method => onMethod(),
            _ when this == CvvResult => onCvvResult(),
            _ when this == AvsResult => onAvsResult(),
            _ when this == _3DsResult => on_3DsResult(),
            _ when this == Related => onRelated(),
            _ when this == RelatedDelay => onRelatedDelay(),
            _ when this == RelatedFloor => onRelatedFloor(),
            _ when this == RelatedCeil => onRelatedCeil(),
            _ when this == Mcc => onMcc(),
            _ when this == MerchantCountry => onMerchantCountry(),
            _ when this == IssuerCountry => onIssuerCountry(),
            _ when this == International => onInternational(),
            _ when this == Platform => onPlatform(),
            _ when this == MethodType => onMethodType(),
            _ when this == Emv => onEmv(),
            _ when this == Misuse => onMisuse(),
            _ when this == Bin => onBin(),
            _ when this == Primary => onPrimary(),
            _ when this == FundingCurrencyEqual => onFundingCurrencyEqual(),
            _ when this == FundingCurrencyNotEqual => onFundingCurrencyNotEqual(),
            _ when this == FundingCurrencyMismatch => onFundingCurrencyMismatch(),
            _ when this == SettledCurrencyMismatch => onSettledCurrencyMismatch(),
            _ when this == Imported => onImported(),
            _ when this == Subscription => onSubscription(),
            _ when this == PublicAuth => onPublicAuth(),
            _ when this == ClientIp => onClientIp(),
            _ when this == DebtRepayment => onDebtRepayment(),
            _ when this == CofType => onCofType(),
            _ when this == EntryMode => onEntryMode(),
            _ => otherwise(Value)
        };

    public void Match(Action onLess,
        Action onEqual,
        Action onNotEqual,
        Action onGreater,
        Action onSwiped,
        Action onSigned,
        Action onType,
        Action onOrigin,
        Action onMethod,
        Action onCvvResult,
        Action onAvsResult,
        Action on_3DsResult,
        Action onRelated,
        Action onRelatedDelay,
        Action onRelatedFloor,
        Action onRelatedCeil,
        Action onMcc,
        Action onMerchantCountry,
        Action onIssuerCountry,
        Action onInternational,
        Action onPlatform,
        Action onMethodType,
        Action onEmv,
        Action onMisuse,
        Action onBin,
        Action onPrimary,
        Action onFundingCurrencyEqual,
        Action onFundingCurrencyNotEqual,
        Action onFundingCurrencyMismatch,
        Action onSettledCurrencyMismatch,
        Action onImported,
        Action onSubscription,
        Action onPublicAuth,
        Action onClientIp,
        Action onDebtRepayment,
        Action onCofType,
        Action onEntryMode,
        Action<string> otherwise)
    {
        if (this == Less) onLess();
        else if (this == Equal) onEqual();
        else if (this == NotEqual) onNotEqual();
        else if (this == Greater) onGreater();
        else if (this == Swiped) onSwiped();
        else if (this == Signed) onSigned();
        else if (this == Type) onType();
        else if (this == Origin) onOrigin();
        else if (this == Method) onMethod();
        else if (this == CvvResult) onCvvResult();
        else if (this == AvsResult) onAvsResult();
        else if (this == _3DsResult) on_3DsResult();
        else if (this == Related) onRelated();
        else if (this == RelatedDelay) onRelatedDelay();
        else if (this == RelatedFloor) onRelatedFloor();
        else if (this == RelatedCeil) onRelatedCeil();
        else if (this == Mcc) onMcc();
        else if (this == MerchantCountry) onMerchantCountry();
        else if (this == IssuerCountry) onIssuerCountry();
        else if (this == International) onInternational();
        else if (this == Platform) onPlatform();
        else if (this == MethodType) onMethodType();
        else if (this == Emv) onEmv();
        else if (this == Misuse) onMisuse();
        else if (this == Bin) onBin();
        else if (this == Primary) onPrimary();
        else if (this == FundingCurrencyEqual) onFundingCurrencyEqual();
        else if (this == FundingCurrencyNotEqual) onFundingCurrencyNotEqual();
        else if (this == FundingCurrencyMismatch) onFundingCurrencyMismatch();
        else if (this == SettledCurrencyMismatch) onSettledCurrencyMismatch();
        else if (this == Imported) onImported();
        else if (this == Subscription) onSubscription();
        else if (this == PublicAuth) onPublicAuth();
        else if (this == ClientIp) onClientIp();
        else if (this == DebtRepayment) onDebtRepayment();
        else if (this == CofType) onCofType();
        else if (this == EntryMode) onEntryMode();
        else otherwise(Value);
    }
}
