using System;
using System.Text.Json.Serialization;
using Payrix.Core.Enum;

namespace Payrix.Models.Enums;

/// <summary>
/// The type of the file that holds this chargebackDocument.
/// The value is set when the file is properly integrated, otherwise will be null.
/// <para>
/// &lt;details&gt;
/// &lt;summary&gt;Valid Values&lt;/summary&gt;
/// </para>
/// <list type="bullet">
///   <item><description><c>jpg</c> - <b>JPG file</b></description></item>
///   <item><description><c>jpeg</c> - <b>JPEG file</b></description></item>
///   <item><description><c>gif</c> - <b>GIF file</b></description></item>
///   <item><description><c>png</c> - <b>PNG file</b></description></item>
///   <item><description><c>pdf</c> - <b>PDF file</b></description></item>
///   <item><description><c>tiff</c> - <b>TIFF file</b></description></item>
///   <item><description><c>tif</c> - <b>TIF file</b></description></item>
/// </list>
/// <para>
/// &lt;/details&gt;
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChargebackDocumentType1>))]
public sealed record ChargebackDocumentType1 : OpenStringEnum<ChargebackDocumentType1>
{
    private ChargebackDocumentType1(string value) : base(value)
    {
    }

    public static readonly ChargebackDocumentType1 Jpg = new("jpg");

    public static readonly ChargebackDocumentType1 Jpeg = new("jpeg");

    public static readonly ChargebackDocumentType1 Gif = new("gif");

    public static readonly ChargebackDocumentType1 Png = new("png");

    public static readonly ChargebackDocumentType1 Pdf = new("pdf");

    public static readonly ChargebackDocumentType1 Tiff = new("tiff");

    public static readonly ChargebackDocumentType1 Tif = new("tif");

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
