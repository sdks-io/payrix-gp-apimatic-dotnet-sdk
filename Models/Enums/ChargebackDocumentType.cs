using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentType>))]
public sealed record ChargebackDocumentType : OpenStringEnum<ChargebackDocumentType>
{
    private ChargebackDocumentType(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentType Jpg = new("jpg");

    public static readonly ChargebackDocumentType Jpeg = new("jpeg");

    public static readonly ChargebackDocumentType Gif = new("gif");

    public static readonly ChargebackDocumentType Png = new("png");

    public static readonly ChargebackDocumentType Pdf = new("pdf");

    public static readonly ChargebackDocumentType Tiff = new("tiff");

    public static readonly ChargebackDocumentType Tif = new("tif");

    public TResult Match<TResult>(Func<TResult> onJpg,
        Func<TResult> onJpeg,
        Func<TResult> onGif,
        Func<TResult> onPng,
        Func<TResult> onPdf,
        Func<TResult> onTiff,
        Func<TResult> onTif,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Jpg => onJpg(),
            _ when this == Jpeg => onJpeg(),
            _ when this == Gif => onGif(),
            _ when this == Png => onPng(),
            _ when this == Pdf => onPdf(),
            _ when this == Tiff => onTiff(),
            _ when this == Tif => onTif(),
            _ => otherwise(Value)
        };

    public void Match(Action onJpg,
        Action onJpeg,
        Action onGif,
        Action onPng,
        Action onPdf,
        Action onTiff,
        Action onTif,
        Action<string> otherwise)
    {
        if (this == Jpg) onJpg();
        else if (this == Jpeg) onJpeg();
        else if (this == Gif) onGif();
        else if (this == Png) onPng();
        else if (this == Pdf) onPdf();
        else if (this == Tiff) onTiff();
        else if (this == Tif) onTif();
        else otherwise(Value);
    }
}
