using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The method used to create the opt-out request.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>api</c> - <b>API</b></description></item>
///   <item><description><c>portal</c> - <b>PORTAL</b></description></item>
///   <item><description><c>widget</c> - <b>WIDGET</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VasOptOutMethod1>))]
public sealed record VasOptOutMethod1 : OpenStringEnum<VasOptOutMethod1>
{
    private VasOptOutMethod1(string value) : base(value)
    {
    }

    public static readonly VasOptOutMethod1 Api = new("api");

    public static readonly VasOptOutMethod1 Portal = new("portal");

    public static readonly VasOptOutMethod1 Widget = new("widget");

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
