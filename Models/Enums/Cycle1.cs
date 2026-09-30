using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// &lt;details&gt;&lt;summary&gt;Valid Values&lt;/summary&gt;
/// <list type="bullet">
///   <item><description><c>retrieval</c> - <b>Initial request from the issuer for more information on this Transaction.</b></description></item>
///   <item><description><c>first</c> - <b>First Chargeback from issuer for this Transaction.</b></description></item>
///   <item><description><c>arbitration</c> - <b>Arbitration is being sought for this Chargeback.</b></description></item>
///   <item><description><c>reversal</c> - <b>Chargeback was reversed.</b></description></item>
///   <item><description><c>representment</c> - <b>Merchant is being represented to the issuer with the Chargeback response posted.</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><c>preArbitration</c> - <b>Chargeback is no longer representable. Merchant must choose to accept or arbitrate with the card brand.</b></description></item>
///   <item><description><c>arbitrationLost</c> - <b>Arbitration lost.</b></description></item>
///   <item><description><c>arbitrationSplit</c> - <b>Arbitration split.</b></description></item>
///   <item><description><c>arbitrationWon</c> - <b>Arbitration won.</b></description></item>
///   <item><description><c>issuerAcceptPreArbitration</c> - <b>Issuer accepted the pre-arbitration response.</b></description></item>
///   <item><description><c>issuerDeclinedPreArbitration</c> - <b>Issuer declined pre-arbitration.</b></description></item>
///   <item><description><c>responseToIssuerPreArbitration</c> - <b>Response to issuer pre-arbitration.</b></description></item>
///   <item><description><c>merchantAcceptedPreArbitration</c> - <b>Merchant accepted the pre-arbitration response.</b></description></item>
///   <item><description><c>merchantDeclinedPreArbitration</c> - <b>Merchant declined the pre-arbitration response.</b></description></item>
///   <item><description><c>preCompliance</c> - <b>Pre-compliance.</b></description></item>
///   <item><description><c>compliance</c> - <b>Compliance.</b> &lt;/details&gt;</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Cycle1>))]
public sealed record Cycle1 : OpenStringEnum<Cycle1>
{
    private Cycle1(string value) : base(value)
    {
    }

    public static readonly Cycle1 Retrieval = new("retrieval");

    public static readonly Cycle1 First = new("first");

    public static readonly Cycle1 Arbitration = new("arbitration");

    public static readonly Cycle1 Reversal = new("reversal");

    public static readonly Cycle1 Representment = new("representment");

    public static readonly Cycle1 PreArbitration = new("preArbitration");

    public static readonly Cycle1 ArbitrationLost = new("arbitrationLost");

    public static readonly Cycle1 ArbitrationSplit = new("arbitrationSplit");

    public static readonly Cycle1 ArbitrationWon = new("arbitrationWon");

    public static readonly Cycle1 IssuerAcceptPreArbitration = new("issuerAcceptPreArbitration");

    public static readonly Cycle1 IssuerDeclinedPreArbitration = new("issuerDeclinedPreArbitration");

    public static readonly Cycle1 ResponseToIssuerPreArbitration = new("responseToIssuerPreArbitration");

    public static readonly Cycle1 MerchantAcceptedPreArbitration = new("merchantAcceptedPreArbitration");

    public static readonly Cycle1 MerchantDeclinedPreArbitration = new("merchantDeclinedPreArbitration");

    public static readonly Cycle1 PreCompliance = new("preCompliance");

    public static readonly Cycle1 Compliance = new("compliance");

    public TResult Match<TResult>(Func<TResult> onRetrieval,
        Func<TResult> onFirst,
        Func<TResult> onArbitration,
        Func<TResult> onReversal,
        Func<TResult> onRepresentment,
        Func<TResult> onPreArbitration,
        Func<TResult> onArbitrationLost,
        Func<TResult> onArbitrationSplit,
        Func<TResult> onArbitrationWon,
        Func<TResult> onIssuerAcceptPreArbitration,
        Func<TResult> onIssuerDeclinedPreArbitration,
        Func<TResult> onResponseToIssuerPreArbitration,
        Func<TResult> onMerchantAcceptedPreArbitration,
        Func<TResult> onMerchantDeclinedPreArbitration,
        Func<TResult> onPreCompliance,
        Func<TResult> onCompliance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Retrieval => onRetrieval(),
            _ when this == First => onFirst(),
            _ when this == Arbitration => onArbitration(),
            _ when this == Reversal => onReversal(),
            _ when this == Representment => onRepresentment(),
            _ when this == PreArbitration => onPreArbitration(),
            _ when this == ArbitrationLost => onArbitrationLost(),
            _ when this == ArbitrationSplit => onArbitrationSplit(),
            _ when this == ArbitrationWon => onArbitrationWon(),
            _ when this == IssuerAcceptPreArbitration => onIssuerAcceptPreArbitration(),
            _ when this == IssuerDeclinedPreArbitration => onIssuerDeclinedPreArbitration(),
            _ when this == ResponseToIssuerPreArbitration => onResponseToIssuerPreArbitration(),
            _ when this == MerchantAcceptedPreArbitration => onMerchantAcceptedPreArbitration(),
            _ when this == MerchantDeclinedPreArbitration => onMerchantDeclinedPreArbitration(),
            _ when this == PreCompliance => onPreCompliance(),
            _ when this == Compliance => onCompliance(),
            _ => otherwise(Value)
        };

    public void Match(Action onRetrieval,
        Action onFirst,
        Action onArbitration,
        Action onReversal,
        Action onRepresentment,
        Action onPreArbitration,
        Action onArbitrationLost,
        Action onArbitrationSplit,
        Action onArbitrationWon,
        Action onIssuerAcceptPreArbitration,
        Action onIssuerDeclinedPreArbitration,
        Action onResponseToIssuerPreArbitration,
        Action onMerchantAcceptedPreArbitration,
        Action onMerchantDeclinedPreArbitration,
        Action onPreCompliance,
        Action onCompliance,
        Action<string> otherwise)
    {
        if (this == Retrieval) onRetrieval();
        else if (this == First) onFirst();
        else if (this == Arbitration) onArbitration();
        else if (this == Reversal) onReversal();
        else if (this == Representment) onRepresentment();
        else if (this == PreArbitration) onPreArbitration();
        else if (this == ArbitrationLost) onArbitrationLost();
        else if (this == ArbitrationSplit) onArbitrationSplit();
        else if (this == ArbitrationWon) onArbitrationWon();
        else if (this == IssuerAcceptPreArbitration) onIssuerAcceptPreArbitration();
        else if (this == IssuerDeclinedPreArbitration) onIssuerDeclinedPreArbitration();
        else if (this == ResponseToIssuerPreArbitration) onResponseToIssuerPreArbitration();
        else if (this == MerchantAcceptedPreArbitration) onMerchantAcceptedPreArbitration();
        else if (this == MerchantDeclinedPreArbitration) onMerchantDeclinedPreArbitration();
        else if (this == PreCompliance) onPreCompliance();
        else if (this == Compliance) onCompliance();
        else otherwise(Value);
    }
}
