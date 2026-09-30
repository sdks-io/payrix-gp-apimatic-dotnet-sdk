using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The medium to use to deliver this Alert.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>email</c> - <b>Deliver the Alert to an email address.</b></description></item>
///   <item><description><c>web</c> - <b>Deliver the Alert through a web site notification.</b></description></item>
///   <item><description><c>app</c> - <b>Deliver the Alert through a mobile application notification.</b></description></item>
///   <item><description><c>sms</c> - <b>Deliver the Alert through an SMS message to a mobile device.</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AlertActionType1>))]
public sealed record AlertActionType1 : OpenStringEnum<AlertActionType1>
{
    private AlertActionType1(string value) : base(value)
    {
    }

    public static readonly AlertActionType1 Email = new("email");

    public static readonly AlertActionType1 Web = new("web");

    public static readonly AlertActionType1 App = new("app");

    public static readonly AlertActionType1 Sms = new("sms");

    public TResult Match<TResult>(Func<TResult> onEmail,
        Func<TResult> onWeb,
        Func<TResult> onApp,
        Func<TResult> onSms,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Email => onEmail(),
            _ when this == Web => onWeb(),
            _ when this == App => onApp(),
            _ when this == Sms => onSms(),
            _ => otherwise(Value)
        };

    public void Match(Action onEmail, Action onWeb, Action onApp, Action onSms, Action<string> otherwise)
    {
        if (this == Email) onEmail();
        else if (this == Web) onWeb();
        else if (this == App) onApp();
        else if (this == Sms) onSms();
        else otherwise(Value);
    }
}
