using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of logic to apply with this Decision Rule.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>less</c> - <b>Less.</b></description></item>
///   <item><description><c>equal</c> - <b>Equal.</b></description></item>
///   <item><description><c>notEqual</c> - <b>Not Equal.</b></description></item>
///   <item><description><c>greater</c> - <b>Greater.</b></description></item>
///   <item><description><c>swiped</c> - <b>Swiped.</b></description></item>
///   <item><description><c>signed</c> - <b>Signed.</b></description></item>
///   <item><description><c>type</c> - <b>Type.</b></description></item>
///   <item><description><c>origin</c> - <b>Origin.</b></description></item>
///   <item><description><c>method</c> - <b>Method.</b></description></item>
///   <item><description><c>cvvResult</c> - <b>CVV Result.</b></description></item>
///   <item><description><c>avsResult</c> - <b>AVS Result.</b></description></item>
///   <item><description><c>3dsResult</c> - <b>3DS Result. The Decision applies based on the results of a 3DS check.</b></description></item>
///   <item><description><c>related</c> - <b>Related.</b></description></item>
///   <item><description><c>relatedDelay</c> - <b>Related Delay.</b></description></item>
///   <item><description><c>relatedFloor</c> - <b>Related Floor.</b></description></item>
///   <item><description><c>relatedCeil</c> - <b>Related Ceil.</b></description></item>
///   <item><description><c>mcc</c> - <b>MCC.</b></description></item>
///   <item><description><c>merchantCountry</c> - <b>Merchant Country.</b></description></item>
///   <item><description><c>issuerCountry</c> - <b>Issuer Country.</b></description></item>
///   <item><description><c>international</c> - <b>International.</b></description></item>
///   <item><description><c>platform</c> - <b>Platform.</b></description></item>
///   <item><description><c>methodType</c> - <b>Method Type.</b></description></item>
///   <item><description><c>emv</c> - <b>EMV.</b></description></item>
///   <item><description><c>misuse</c> - <b>Misuse.</b></description></item>
///   <item><description><c>bin</c> - <b>BIN.</b></description></item>
///   <item><description><c>primary</c> - <b>Primary.</b></description></item>
///   <item><description><c>fundingCurrencyEqual</c> - <b>Funding Currency Equal.</b></description></item>
///   <item><description><c>fundingCurrencyNotEqual</c> - <b>Funding Currency Not Equal.</b></description></item>
///   <item><description><c>fundingCurrencyMismatch</c> - <b>Funding Currency Mismatch.</b></description></item>
///   <item><description><c>settledCurrencyMismatch</c> - <b>Settled Currency Mismatch.</b></description></item>
///   <item><description><c>imported</c> - <b>Imported.</b></description></item>
///   <item><description><c>subscription</c> - <b>Subscription.</b></description></item>
///   <item><description><c>publicAuth</c> - <b>Public Auth.</b></description></item>
///   <item><description><c>clientIp</c> - <b>Client IP.</b></description></item>
///   <item><description><c>debtRepayment</c> - <b>Debt Repayment.</b></description></item>
///   <item><description><c>cofType</c> - <b>COF Type.</b></description></item>
///   <item><description><c>entryMode</c> - <b>Entry Mode.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DecisionRuleType1>))]
public sealed record DecisionRuleType1 : OpenStringEnum<DecisionRuleType1>
{
    private DecisionRuleType1(string value) : base(value)
    {
    }

    public static readonly DecisionRuleType1 Less = new("less");

    public static readonly DecisionRuleType1 Equal = new("equal");

    public static readonly DecisionRuleType1 NotEqual = new("notEqual");

    public static readonly DecisionRuleType1 Greater = new("greater");

    public static readonly DecisionRuleType1 Swiped = new("swiped");

    public static readonly DecisionRuleType1 Signed = new("signed");

    public static readonly DecisionRuleType1 Type = new("type");

    public static readonly DecisionRuleType1 Origin = new("origin");

    public static readonly DecisionRuleType1 Method = new("method");

    public static readonly DecisionRuleType1 CvvResult = new("cvvResult");

    public static readonly DecisionRuleType1 AvsResult = new("avsResult");

    public static readonly DecisionRuleType1 _3DsResult = new("3dsResult");

    public static readonly DecisionRuleType1 Related = new("related");

    public static readonly DecisionRuleType1 RelatedDelay = new("relatedDelay");

    public static readonly DecisionRuleType1 RelatedFloor = new("relatedFloor");

    public static readonly DecisionRuleType1 RelatedCeil = new("relatedCeil");

    public static readonly DecisionRuleType1 Mcc = new("mcc");

    public static readonly DecisionRuleType1 MerchantCountry = new("merchantCountry");

    public static readonly DecisionRuleType1 IssuerCountry = new("issuerCountry");

    public static readonly DecisionRuleType1 International = new("international");

    public static readonly DecisionRuleType1 Platform = new("platform");

    public static readonly DecisionRuleType1 MethodType = new("methodType");

    public static readonly DecisionRuleType1 Emv = new("emv");

    public static readonly DecisionRuleType1 Misuse = new("misuse");

    public static readonly DecisionRuleType1 Bin = new("bin");

    public static readonly DecisionRuleType1 Primary = new("primary");

    public static readonly DecisionRuleType1 FundingCurrencyEqual = new("fundingCurrencyEqual");

    public static readonly DecisionRuleType1 FundingCurrencyNotEqual = new("fundingCurrencyNotEqual");

    public static readonly DecisionRuleType1 FundingCurrencyMismatch = new("fundingCurrencyMismatch");

    public static readonly DecisionRuleType1 SettledCurrencyMismatch = new("settledCurrencyMismatch");

    public static readonly DecisionRuleType1 Imported = new("imported");

    public static readonly DecisionRuleType1 Subscription = new("subscription");

    public static readonly DecisionRuleType1 PublicAuth = new("publicAuth");

    public static readonly DecisionRuleType1 ClientIp = new("clientIp");

    public static readonly DecisionRuleType1 DebtRepayment = new("debtRepayment");

    public static readonly DecisionRuleType1 CofType = new("cofType");

    public static readonly DecisionRuleType1 EntryMode = new("entryMode");

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
