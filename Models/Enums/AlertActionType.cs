using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AlertActionType>))]
public sealed record AlertActionType : OpenStringEnum<AlertActionType>
{
    private AlertActionType(string value) : base(value)
    {
    }

    public static readonly AlertActionType Email = new("email");

    public static readonly AlertActionType Web = new("web");

    public static readonly AlertActionType App = new("app");

    public static readonly AlertActionType Sms = new("sms");

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
