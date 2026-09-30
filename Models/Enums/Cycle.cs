using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Cycle>))]
public sealed record Cycle : OpenStringEnum<Cycle>
{
    private Cycle(string value) : base(value)
    {
    }

    public static readonly Cycle Retrieval = new("retrieval");

    public static readonly Cycle First = new("first");

    public static readonly Cycle Arbitration = new("arbitration");

    public static readonly Cycle Reversal = new("reversal");

    public static readonly Cycle Representment = new("representment");

    public static readonly Cycle PreArbitration = new("preArbitration");

    public static readonly Cycle ArbitrationLost = new("arbitrationLost");

    public static readonly Cycle ArbitrationSplit = new("arbitrationSplit");

    public static readonly Cycle ArbitrationWon = new("arbitrationWon");

    public static readonly Cycle IssuerAcceptPreArbitration = new("issuerAcceptPreArbitration");

    public static readonly Cycle IssuerDeclinedPreArbitration = new("issuerDeclinedPreArbitration");

    public static readonly Cycle ResponseToIssuerPreArbitration = new("responseToIssuerPreArbitration");

    public static readonly Cycle MerchantAcceptedPreArbitration = new("merchantAcceptedPreArbitration");

    public static readonly Cycle MerchantDeclinedPreArbitration = new("merchantDeclinedPreArbitration");

    public static readonly Cycle PreCompliance = new("preCompliance");

    public static readonly Cycle Compliance = new("compliance");

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
