using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<HoldsHoldSource>))]
public sealed record HoldsHoldSource : OpenStringEnum<HoldsHoldSource>
{
    private HoldsHoldSource(string value) : base(value)
    {
    }

    public static readonly HoldsHoldSource DsModelPolicyRun = new("DS_MODEL_POLICY_RUN");

    public static readonly HoldsHoldSource ApiDecision = new("API_DECISION");

    public static readonly HoldsHoldSource PolicyRun = new("POLICY_RUN");

    public static readonly HoldsHoldSource RiskAlert = new("RISK_ALERT");

    public static readonly HoldsHoldSource Manual = new("MANUAL");

    public static readonly HoldsHoldSource Error = new("ERROR");

    public TResult Match<TResult>(Func<TResult> onDsModelPolicyRun,
        Func<TResult> onApiDecision,
        Func<TResult> onPolicyRun,
        Func<TResult> onRiskAlert,
        Func<TResult> onManual,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DsModelPolicyRun => onDsModelPolicyRun(),
            _ when this == ApiDecision => onApiDecision(),
            _ when this == PolicyRun => onPolicyRun(),
            _ when this == RiskAlert => onRiskAlert(),
            _ when this == Manual => onManual(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onDsModelPolicyRun,
        Action onApiDecision,
        Action onPolicyRun,
        Action onRiskAlert,
        Action onManual,
        Action onError,
        Action<string> otherwise)
    {
        if (this == DsModelPolicyRun) onDsModelPolicyRun();
        else if (this == ApiDecision) onApiDecision();
        else if (this == PolicyRun) onPolicyRun();
        else if (this == RiskAlert) onRiskAlert();
        else if (this == Manual) onManual();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
