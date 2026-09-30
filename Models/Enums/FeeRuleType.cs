using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FeeRuleType>))]
public sealed record FeeRuleType : OpenStringEnum<FeeRuleType>
{
    private FeeRuleType(string value) : base(value)
    {
    }

    public static readonly FeeRuleType _3DsResult = new("3dsResult");

    public static readonly FeeRuleType ActiveInactive = new("activeInactive");

    public static readonly FeeRuleType AvsResult = new("avsResult");

    public static readonly FeeRuleType Bin = new("bin");

    public static readonly FeeRuleType Business = new("business");

    public static readonly FeeRuleType Corporate = new("corporate");

    public static readonly FeeRuleType CvvResult = new("cvvResult");

    public static readonly FeeRuleType DynamicallyRouted = new("dynamicallyRouted");

    public static readonly FeeRuleType Emv = new("emv");

    public static readonly FeeRuleType Entity = new("entity");

    public static readonly FeeRuleType Equal = new("equal");

    public static readonly FeeRuleType FraudSightEnabled = new("fraudSightEnabled");

    public static readonly FeeRuleType FundingCurrencyEqual = new("fundingCurrencyEqual");

    public static readonly FeeRuleType FundingCurrencyMismatch = new("fundingCurrencyMismatch");

    public static readonly FeeRuleType FundingCurrencyNotEqual = new("fundingCurrencyNotEqual");

    public static readonly FeeRuleType FundingEnabled = new("fundingEnabled");

    public static readonly FeeRuleType Greater = new("greater");

    public static readonly FeeRuleType IcRetainPassthruRefund = new("icRetainPassthruRefund");

    public static readonly FeeRuleType Imported = new("imported");

    public static readonly FeeRuleType Interchange = new("interchange");

    public static readonly FeeRuleType International = new("international");

    public static readonly FeeRuleType IssuerCountry = new("issuerCountry");

    public static readonly FeeRuleType Less = new("less");

    public static readonly FeeRuleType Mcc = new("mcc");

    public static readonly FeeRuleType MerchantCountry = new("merchantCountry");

    public static readonly FeeRuleType Method = new("method");

    public static readonly FeeRuleType MethodType = new("methodType");

    public static readonly FeeRuleType Misuse = new("misuse");

    public static readonly FeeRuleType NotEqual = new("notEqual");

    public static readonly FeeRuleType OmnitokensEnabled = new("omnitokensEnabled");

    public static readonly FeeRuleType Origin = new("origin");

    public static readonly FeeRuleType Platform = new("platform");

    public static readonly FeeRuleType Related = new("related");

    public static readonly FeeRuleType RelatedCeil = new("relatedCeil");

    public static readonly FeeRuleType RelatedDelay = new("relatedDelay");

    public static readonly FeeRuleType RelatedFloor = new("relatedFloor");

    public static readonly FeeRuleType SameDay = new("sameDay");

    public static readonly FeeRuleType SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly FeeRuleType Signed = new("signed");

    public static readonly FeeRuleType SoftPos = new("softPos");

    public static readonly FeeRuleType Status = new("status");

    public static readonly FeeRuleType Subscription = new("subscription");

    public static readonly FeeRuleType Swiped = new("swiped");

    public static readonly FeeRuleType TaxForm1099K = new("taxForm1099k");

    public static readonly FeeRuleType Type = new("type");

    public TResult Match<TResult>(Func<TResult> on_3DsResult,
        Func<TResult> onActiveInactive,
        Func<TResult> onAvsResult,
        Func<TResult> onBin,
        Func<TResult> onBusiness,
        Func<TResult> onCorporate,
        Func<TResult> onCvvResult,
        Func<TResult> onDynamicallyRouted,
        Func<TResult> onEmv,
        Func<TResult> onEntity,
        Func<TResult> onEqual,
        Func<TResult> onFraudSightEnabled,
        Func<TResult> onFundingCurrencyEqual,
        Func<TResult> onFundingCurrencyMismatch,
        Func<TResult> onFundingCurrencyNotEqual,
        Func<TResult> onFundingEnabled,
        Func<TResult> onGreater,
        Func<TResult> onIcRetainPassthruRefund,
        Func<TResult> onImported,
        Func<TResult> onInterchange,
        Func<TResult> onInternational,
        Func<TResult> onIssuerCountry,
        Func<TResult> onLess,
        Func<TResult> onMcc,
        Func<TResult> onMerchantCountry,
        Func<TResult> onMethod,
        Func<TResult> onMethodType,
        Func<TResult> onMisuse,
        Func<TResult> onNotEqual,
        Func<TResult> onOmnitokensEnabled,
        Func<TResult> onOrigin,
        Func<TResult> onPlatform,
        Func<TResult> onRelated,
        Func<TResult> onRelatedCeil,
        Func<TResult> onRelatedDelay,
        Func<TResult> onRelatedFloor,
        Func<TResult> onSameDay,
        Func<TResult> onSettledCurrencyMismatch,
        Func<TResult> onSigned,
        Func<TResult> onSoftPos,
        Func<TResult> onStatus,
        Func<TResult> onSubscription,
        Func<TResult> onSwiped,
        Func<TResult> onTaxForm1099K,
        Func<TResult> onType,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _3DsResult => on_3DsResult(),
            _ when this == ActiveInactive => onActiveInactive(),
            _ when this == AvsResult => onAvsResult(),
            _ when this == Bin => onBin(),
            _ when this == Business => onBusiness(),
            _ when this == Corporate => onCorporate(),
            _ when this == CvvResult => onCvvResult(),
            _ when this == DynamicallyRouted => onDynamicallyRouted(),
            _ when this == Emv => onEmv(),
            _ when this == Entity => onEntity(),
            _ when this == Equal => onEqual(),
            _ when this == FraudSightEnabled => onFraudSightEnabled(),
            _ when this == FundingCurrencyEqual => onFundingCurrencyEqual(),
            _ when this == FundingCurrencyMismatch => onFundingCurrencyMismatch(),
            _ when this == FundingCurrencyNotEqual => onFundingCurrencyNotEqual(),
            _ when this == FundingEnabled => onFundingEnabled(),
            _ when this == Greater => onGreater(),
            _ when this == IcRetainPassthruRefund => onIcRetainPassthruRefund(),
            _ when this == Imported => onImported(),
            _ when this == Interchange => onInterchange(),
            _ when this == International => onInternational(),
            _ when this == IssuerCountry => onIssuerCountry(),
            _ when this == Less => onLess(),
            _ when this == Mcc => onMcc(),
            _ when this == MerchantCountry => onMerchantCountry(),
            _ when this == Method => onMethod(),
            _ when this == MethodType => onMethodType(),
            _ when this == Misuse => onMisuse(),
            _ when this == NotEqual => onNotEqual(),
            _ when this == OmnitokensEnabled => onOmnitokensEnabled(),
            _ when this == Origin => onOrigin(),
            _ when this == Platform => onPlatform(),
            _ when this == Related => onRelated(),
            _ when this == RelatedCeil => onRelatedCeil(),
            _ when this == RelatedDelay => onRelatedDelay(),
            _ when this == RelatedFloor => onRelatedFloor(),
            _ when this == SameDay => onSameDay(),
            _ when this == SettledCurrencyMismatch => onSettledCurrencyMismatch(),
            _ when this == Signed => onSigned(),
            _ when this == SoftPos => onSoftPos(),
            _ when this == Status => onStatus(),
            _ when this == Subscription => onSubscription(),
            _ when this == Swiped => onSwiped(),
            _ when this == TaxForm1099K => onTaxForm1099K(),
            _ when this == Type => onType(),
            _ => otherwise(Value)
        };

    public void Match(Action on_3DsResult,
        Action onActiveInactive,
        Action onAvsResult,
        Action onBin,
        Action onBusiness,
        Action onCorporate,
        Action onCvvResult,
        Action onDynamicallyRouted,
        Action onEmv,
        Action onEntity,
        Action onEqual,
        Action onFraudSightEnabled,
        Action onFundingCurrencyEqual,
        Action onFundingCurrencyMismatch,
        Action onFundingCurrencyNotEqual,
        Action onFundingEnabled,
        Action onGreater,
        Action onIcRetainPassthruRefund,
        Action onImported,
        Action onInterchange,
        Action onInternational,
        Action onIssuerCountry,
        Action onLess,
        Action onMcc,
        Action onMerchantCountry,
        Action onMethod,
        Action onMethodType,
        Action onMisuse,
        Action onNotEqual,
        Action onOmnitokensEnabled,
        Action onOrigin,
        Action onPlatform,
        Action onRelated,
        Action onRelatedCeil,
        Action onRelatedDelay,
        Action onRelatedFloor,
        Action onSameDay,
        Action onSettledCurrencyMismatch,
        Action onSigned,
        Action onSoftPos,
        Action onStatus,
        Action onSubscription,
        Action onSwiped,
        Action onTaxForm1099K,
        Action onType,
        Action<string> otherwise)
    {
        if (this == _3DsResult) on_3DsResult();
        else if (this == ActiveInactive) onActiveInactive();
        else if (this == AvsResult) onAvsResult();
        else if (this == Bin) onBin();
        else if (this == Business) onBusiness();
        else if (this == Corporate) onCorporate();
        else if (this == CvvResult) onCvvResult();
        else if (this == DynamicallyRouted) onDynamicallyRouted();
        else if (this == Emv) onEmv();
        else if (this == Entity) onEntity();
        else if (this == Equal) onEqual();
        else if (this == FraudSightEnabled) onFraudSightEnabled();
        else if (this == FundingCurrencyEqual) onFundingCurrencyEqual();
        else if (this == FundingCurrencyMismatch) onFundingCurrencyMismatch();
        else if (this == FundingCurrencyNotEqual) onFundingCurrencyNotEqual();
        else if (this == FundingEnabled) onFundingEnabled();
        else if (this == Greater) onGreater();
        else if (this == IcRetainPassthruRefund) onIcRetainPassthruRefund();
        else if (this == Imported) onImported();
        else if (this == Interchange) onInterchange();
        else if (this == International) onInternational();
        else if (this == IssuerCountry) onIssuerCountry();
        else if (this == Less) onLess();
        else if (this == Mcc) onMcc();
        else if (this == MerchantCountry) onMerchantCountry();
        else if (this == Method) onMethod();
        else if (this == MethodType) onMethodType();
        else if (this == Misuse) onMisuse();
        else if (this == NotEqual) onNotEqual();
        else if (this == OmnitokensEnabled) onOmnitokensEnabled();
        else if (this == Origin) onOrigin();
        else if (this == Platform) onPlatform();
        else if (this == Related) onRelated();
        else if (this == RelatedCeil) onRelatedCeil();
        else if (this == RelatedDelay) onRelatedDelay();
        else if (this == RelatedFloor) onRelatedFloor();
        else if (this == SameDay) onSameDay();
        else if (this == SettledCurrencyMismatch) onSettledCurrencyMismatch();
        else if (this == Signed) onSigned();
        else if (this == SoftPos) onSoftPos();
        else if (this == Status) onStatus();
        else if (this == Subscription) onSubscription();
        else if (this == Swiped) onSwiped();
        else if (this == TaxForm1099K) onTaxForm1099K();
        else if (this == Type) onType();
        else otherwise(Value);
    }
}
