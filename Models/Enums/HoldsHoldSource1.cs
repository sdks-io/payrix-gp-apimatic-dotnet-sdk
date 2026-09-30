using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// Field created to know the reason for why a hold was created.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>DS_MODEL_POLICY_RUN</c> - <b>DS_MODEL_POLICY_RUN</b></description></item>
///   <item><description><c>API_DECISION</c> - <b>API_DECISION</b></description></item>
///   <item><description><c>POLICY_RUN</c> - <b>POLICY_RUN</b></description></item>
///   <item><description><c>RISK_ALERT</c> - <b>RISK_ALERT</b></description></item>
///   <item><description><c>MANUAL</c> - <b>MANUAL</b></description></item>
///   <item><description><c>ERROR</c> - <b>ERROR</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<HoldsHoldSource1>))]
public sealed record HoldsHoldSource1 : OpenStringEnum<HoldsHoldSource1>
{
    private HoldsHoldSource1(string value) : base(value)
    {
    }

    public static readonly HoldsHoldSource1 DsModelPolicyRun = new("DS_MODEL_POLICY_RUN");

    public static readonly HoldsHoldSource1 ApiDecision = new("API_DECISION");

    public static readonly HoldsHoldSource1 PolicyRun = new("POLICY_RUN");

    public static readonly HoldsHoldSource1 RiskAlert = new("RISK_ALERT");

    public static readonly HoldsHoldSource1 Manual = new("MANUAL");

    public static readonly HoldsHoldSource1 Error = new("ERROR");

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
