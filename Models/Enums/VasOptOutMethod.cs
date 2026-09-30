using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<VasOptOutMethod>))]
public sealed record VasOptOutMethod : OpenStringEnum<VasOptOutMethod>
{
    private VasOptOutMethod(string value) : base(value)
    {
    }

    public static readonly VasOptOutMethod Api = new("api");

    public static readonly VasOptOutMethod Portal = new("portal");

    public static readonly VasOptOutMethod Widget = new("widget");

    public TResult Match<TResult>(Func<TResult> onApi,
        Func<TResult> onPortal,
        Func<TResult> onWidget,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Api => onApi(),
            _ when this == Portal => onPortal(),
            _ when this == Widget => onWidget(),
            _ => otherwise(Value)
        };

    public void Match(Action onApi, Action onPortal, Action onWidget, Action<string> otherwise)
    {
        if (this == Api) onApi();
        else if (this == Portal) onPortal();
        else if (this == Widget) onWidget();
        else otherwise(Value);
    }
}
