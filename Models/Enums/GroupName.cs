using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<GroupName>))]
public sealed record GroupName : OpenStringEnum<GroupName>
{
    private GroupName(string value) : base(value)
    {
    }

    public static readonly GroupName Piecpa = new("PIECPA");

    public static readonly GroupName Picnp = new("PICNP");

    public static readonly GroupName Pacpa = new("PACPA");

    public static readonly GroupName Incnp = new("INCNP");

    public static readonly GroupName Pikcpa = new("PIKCPA");

    public static readonly GroupName Iecnp = new("IECNP");

    public static readonly GroupName Acpa = new("ACPA");

    public static readonly GroupName Pacnp = new("PACNP");

    public static readonly GroupName Piecnp = new("PIECNP");

    public static readonly GroupName Ikcpa = new("IKCPA");

    public static readonly GroupName Acnp = new("ACNP");

    public static readonly GroupName Pincnp = new("PINCNP");

    public static readonly GroupName Iecpa = new("IECPA");

    public static readonly GroupName Icnp = new("ICNP");

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
