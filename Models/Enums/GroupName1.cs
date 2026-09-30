using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The name of the group for this FraudSight enablement.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>PIECPA</c> - Post Network -Decision Non EMV CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>PICNP</c> - Post Network - Decision CNP only &amp; Inform CP.</description></item>
///   <item><description><c>PACPA</c> - Post Network - Decision All CP Authorizations.</description></item>
///   <item><description><c>INCNP</c> - Pre Network -Decision Non-Recurring CNP &amp; Inform CP.</description></item>
///   <item><description><c>PIKCPA</c> - Post Network -Decision Key Entered CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>IECNP</c> - Pre Network -Decision CNP and Non EMV CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>ACPA</c> - Pre Network - Decision All CP Authorizations.</description></item>
///   <item><description><c>PACNP</c> - Post Network - Decision All Authorizations (CNP &amp; CP).</description></item>
///   <item><description><c>PIECNP</c> - Post Network -Decision CNP and Non EMV CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>IKCPA</c> - Pre Network -Decision Key Entered CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>ACNP</c> - Pre Network - Decision All Authorizations (CNP &amp; CP).</description></item>
///   <item><description><c>PINCNP</c> - Post Network -Decision Non-Recurring CNP &amp; Inform CP.</description></item>
///   <item><description><c>IECPA</c> - Pre Network -Decision Non EMV CP &amp; Inform remaining CP.</description></item>
///   <item><description><c>ICNP</c> - Pre Network - Decision CNP only &amp; Inform CP.</description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<GroupName1>))]
public sealed record GroupName1 : OpenStringEnum<GroupName1>
{
    private GroupName1(string value) : base(value)
    {
    }

    public static readonly GroupName1 Piecpa = new("PIECPA");

    public static readonly GroupName1 Picnp = new("PICNP");

    public static readonly GroupName1 Pacpa = new("PACPA");

    public static readonly GroupName1 Incnp = new("INCNP");

    public static readonly GroupName1 Pikcpa = new("PIKCPA");

    public static readonly GroupName1 Iecnp = new("IECNP");

    public static readonly GroupName1 Acpa = new("ACPA");

    public static readonly GroupName1 Pacnp = new("PACNP");

    public static readonly GroupName1 Piecnp = new("PIECNP");

    public static readonly GroupName1 Ikcpa = new("IKCPA");

    public static readonly GroupName1 Acnp = new("ACNP");

    public static readonly GroupName1 Pincnp = new("PINCNP");

    public static readonly GroupName1 Iecpa = new("IECPA");

    public static readonly GroupName1 Icnp = new("ICNP");

    public TResult Match<TResult>(Func<TResult> onPiecpa,
        Func<TResult> onPicnp,
        Func<TResult> onPacpa,
        Func<TResult> onIncnp,
        Func<TResult> onPikcpa,
        Func<TResult> onIecnp,
        Func<TResult> onAcpa,
        Func<TResult> onPacnp,
        Func<TResult> onPiecnp,
        Func<TResult> onIkcpa,
        Func<TResult> onAcnp,
        Func<TResult> onPincnp,
        Func<TResult> onIecpa,
        Func<TResult> onIcnp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Piecpa => onPiecpa(),
            _ when this == Picnp => onPicnp(),
            _ when this == Pacpa => onPacpa(),
            _ when this == Incnp => onIncnp(),
            _ when this == Pikcpa => onPikcpa(),
            _ when this == Iecnp => onIecnp(),
            _ when this == Acpa => onAcpa(),
            _ when this == Pacnp => onPacnp(),
            _ when this == Piecnp => onPiecnp(),
            _ when this == Ikcpa => onIkcpa(),
            _ when this == Acnp => onAcnp(),
            _ when this == Pincnp => onPincnp(),
            _ when this == Iecpa => onIecpa(),
            _ when this == Icnp => onIcnp(),
            _ => otherwise(Value)
        };

    public void Match(Action onPiecpa,
        Action onPicnp,
        Action onPacpa,
        Action onIncnp,
        Action onPikcpa,
        Action onIecnp,
        Action onAcpa,
        Action onPacnp,
        Action onPiecnp,
        Action onIkcpa,
        Action onAcnp,
        Action onPincnp,
        Action onIecpa,
        Action onIcnp,
        Action<string> otherwise)
    {
        if (this == Piecpa) onPiecpa();
        else if (this == Picnp) onPicnp();
        else if (this == Pacpa) onPacpa();
        else if (this == Incnp) onIncnp();
        else if (this == Pikcpa) onPikcpa();
        else if (this == Iecnp) onIecnp();
        else if (this == Acpa) onAcpa();
        else if (this == Pacnp) onPacnp();
        else if (this == Piecnp) onPiecnp();
        else if (this == Ikcpa) onIkcpa();
        else if (this == Acnp) onAcnp();
        else if (this == Pincnp) onPincnp();
        else if (this == Iecpa) onIecpa();
        else if (this == Icnp) onIcnp();
        else otherwise(Value);
    }
}
